using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DashBoard1.Data;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Services
{
    public class RejectedStatsService : IRejectedStatsService
    {
        private readonly AppDbContext _context;

        public RejectedStatsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<(int, decimal)> GetRejectedAttestationsAsync(Guid userId)
        {
            try
            {
                var rejectedAttestations = await _context.EfactRejectionReasons
                    .Where(e => e.AttestId != null)
                    .Join(_context.AttestedSessions,
                          e => e.AttestId,
                          a => a.AttestId,
                          (e, a) => a.TotalAmount)
                    .ToListAsync();

                int count = rejectedAttestations.Count;
                decimal totalAmount = rejectedAttestations.Sum();

                return (count, totalAmount);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public async Task<(int, decimal)> GetRejectedInvoicesAsync(Guid userId)
        {
            try
            {
                var rejectedInvoices = await _context.EfactRejectionReasons
                    .Where(e => e.EfactId != null)
                    .Join(_context.ElectronicInvoices,
                          e => e.EfactId,
                          f => f.ElectronicInvoiceId,
                          (e, f) => f.TotalHonorarium)
                    .ToListAsync();

                int count = rejectedInvoices.Count;
                decimal totalAmount = rejectedInvoices.Sum();

                return (count, totalAmount);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public async Task<IEnumerable<object>> GetTop10NomenclatureStatsAsync(Guid userId)
        {
            try
            {
                var topNomenclatureStats = await _context.AttestLineItems
                    .GroupBy(a => a.NomenclatureCode)
                    .OrderByDescending(g => g.Count())
                    .Take(10)
                    .Select(g => new
                    {
                        NomenclatureCode = g.Key,
                        Nombre = g.Count(),
                        Montant_Total = g.Sum(a => a.Reimbursement)
                    })
                    .ToListAsync();

                return topNomenclatureStats;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }

}
