using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DashBoard1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static DashBoard1.Controllers.RejectedStatsController;

namespace DashBoard1.Services
{
    public class RejectedStatsService : IRejectedStatsService
    {
        private readonly AppDbContext _context;
        private readonly ILogger<RejectedStatsService> _logger;

        public RejectedStatsService(AppDbContext context, ILogger<RejectedStatsService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<(int nbAttest, decimal montantTotalAttestedSessions, int nbInvoices, decimal montantTotalElectronicInvoices)> GetCombinedReportAsync(Guid userId, DateTime startDate, DateTime endDate)
        {
            // Requête pour les AttestedSessions avec filtre de date
            var attestedSessionsResult = await _context.EfactRejectionReasons
                .Join(_context.AttestedSessions,
                      e => e.AttestId,
                      a => a.AttestId,
                      (e, a) => new { e, a })
                .Where(x => x.a.CreationDate >= startDate && x.a.CreationDate <= endDate)
                .GroupBy(x => true)
                .Select(g => new
                {
                    nbAttest = g.Count(),
                    montantTotal = g.Sum(x => x.a.TotalAmount)
                })
                .FirstOrDefaultAsync();

            // Requête pour les ElectronicInvoices avec filtre de date
            var electronicInvoicesResult = await _context.EfactRejectionReasons
                .Join(_context.ElectronicInvoices,
                      e => e.EfactId,
                      f => f.ElectronicInvoiceId,
                      (e, f) => new { e, f })
                .Where(x => x.f.CreationDate >= startDate && x.f.CreationDate <= endDate)
                .GroupBy(x => true)
                .Select(g => new
                {
                    nbInvoices = g.Count(),
                    montantTotal = g.Sum(x => x.f.TotalHonorarium)
                })
                .FirstOrDefaultAsync();

            if (attestedSessionsResult == null)
            {
                _logger.LogWarning("No data found for attested sessions in GetCombinedReportAsync");
                attestedSessionsResult = new { nbAttest = 0, montantTotal = 0m };
            }

            if (electronicInvoicesResult == null)
            {
                _logger.LogWarning("No data found for electronic invoices in GetCombinedReportAsync");
                electronicInvoicesResult = new { nbInvoices = 0, montantTotal = 0m };
            }

            _logger.LogInformation($"GetCombinedReportAsync: nbAttest={attestedSessionsResult.nbAttest}, montantTotalAttestedSessions={attestedSessionsResult.montantTotal}, nbInvoices={electronicInvoicesResult.nbInvoices}, montantTotalElectronicInvoices={electronicInvoicesResult.montantTotal}");

            return (attestedSessionsResult.nbAttest, attestedSessionsResult.montantTotal, electronicInvoicesResult.nbInvoices, electronicInvoicesResult.montantTotal);
        }

        public async Task<IEnumerable<NomenclatureStatsDto>> GetTop10NomenclatureStatsAsync(Guid userId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var topNomenclatureStats = await _context.AttestLineItems
                    .Where(a => a.CreationDate >= startDate && a.CreationDate <= endDate)
                    .GroupBy(a => a.NomenclatureCode)
                    .OrderByDescending(g => g.Count())
                    .Take(10)
                    .Select(g => new NomenclatureStatsDto
                    {
                        NomenclatureCode = g.Key,
                        Nombre = g.Count(),
                        MontantTotal = g.Sum(a => a.Reimbursement)
                    })
                    .ToListAsync();

                return topNomenclatureStats;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetTop10NomenclatureStatsAsync");
                throw;
            }
        }

    }
}
