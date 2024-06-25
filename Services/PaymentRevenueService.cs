using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DashBoard1.Data;
using Microsoft.EntityFrameworkCore;
using static DashBoard1.Controllers.PaymentRevenueController;

namespace DashBoard1.Services
{
    public class PaymentRevenueService : IPaymentRevenueService
    {
        private readonly AppDbContext _context;
        public PaymentRevenueService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RevenueByPayerDto>> GetRevenueByPayerAsync(Guid userId, DateTime startDate, DateTime endDate)
        {
            var revenueByPayer = await _context.Payments
                .Where(p => p.PaymentDate >= startDate && p.PaymentDate <= endDate)
                .Join(
                    _context.AttestedSessions,
                    payment => payment.AttestId,
                    attestedSession => attestedSession.AttestId,
                    (payment, attestedSession) => new
                    {
                        Type_b = payment.Payer == 1 ? "Patient" :
                                 payment.Payer == 4 ? "Mutuelle" :
                                 "Autre",
                        payment.Amount
                    })
                .GroupBy(p => p.Type_b)
                .Select(g => new RevenueByPayerDto
                {
                    Type_b = g.Key,
                    Chiffre_Affaire = g.Sum(p => p.Amount)
                })
                .ToListAsync();

            return revenueByPayer;
        }

        public async Task<IEnumerable<TotalSessionRevenueDto>> GetTotalSessionRevenueAsync(Guid userId, DateTime startDate, DateTime endDate)
        {
            var totalSessionRevenue = await _context.Payments
                .Where(p => p.PaymentDate >= startDate && p.PaymentDate <= endDate)
                .Join(
                    _context.AttestedSessions,
                    payment => payment.AttestId,
                    attestedSession => attestedSession.AttestId,
                    (payment, attestedSession) => new
                    {
                        Type_b = payment.Payer == 1 ? "Patient" :
                                 payment.Payer == 4 ? "Mutuelle" :
                                 "Autre",
                        attestedSession.TotalAmount
                    })
                .GroupBy(p => p.Type_b)
                .Select(g => new TotalSessionRevenueDto
                {
                    Type_b = g.Key,
                    Total_a_facturer = g.Sum(p => p.TotalAmount)
                })
                .ToListAsync();

            return totalSessionRevenue;
        }

        public async Task<IEnumerable<BalanceByPayerDto>> GetBalanceByPayerAsync(Guid userId, DateTime startDate, DateTime endDate)
        {
            var balanceByPayer = await _context.Payments
                .Where(p => p.PaymentDate >= startDate && p.PaymentDate <= endDate)
                .Join(_context.AttestedSessions,
                      payment => payment.AttestId,
                      attestedSession => attestedSession.AttestId,
                      (payment, attestedSession) => new
                      {
                          Type_b = payment.Payer == 1 ? "Patient" :
                                   payment.Payer == 4 ? "Mutuelle" :
                                   "Autre",
                          payment.Amount,
                          attestedSession.TotalAmount
                      })
                .GroupBy(p => p.Type_b)
                .Select(g => new BalanceByPayerDto
                {
                    Type_b = g.Key,
                    Solde_du = g.Sum(p => p.TotalAmount) - g.Sum(p => p.Amount)
                })
                .ToListAsync();

            return balanceByPayer;
        }

    }
}
