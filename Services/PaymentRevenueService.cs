using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DashBoard1.Data;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Services
{
    public class PaymentRevenueService : IPaymentRevenueService
    {
        private readonly AppDbContext _context;
        public PaymentRevenueService(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<object>> GetRevenueByPayerAsync(Guid userId)
        {
            try
            {
                var revenueByPayer = await _context.Payments
                    .Join(
                        _context.AttestedSessions,
                        payment => payment.AttestId,
                        attestedSession => attestedSession.AttestId,
                        (payment, attestedSession) => new
                        {
                            Type_Payment = payment.PaymentMode == 1 ? "Cash" :
                                           payment.PaymentMode == 2 ? "Bancontact" :
                                           payment.PaymentMode == 3 ? "Virement" :
                                           "Autre",
                            Type_b = payment.Payer == 1 ? "Patient" :
                                     payment.Payer == 4 ? "Mutuelle" :
                                     "Autre",
                            payment.Amount
                        })
                    .GroupBy(p => new { p.Type_b })
                    .Select(g => new
                    {
                        Type_b = g.Key.Type_b,
                        Chiffre_Affaire = g.Sum(p => p.Amount)
                    })
                    .ToListAsync();

                return revenueByPayer;
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici
                throw ex;
            }
        }

        public Task<IEnumerable<object>> GetTotalRevenueByPayerAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<object>> GetTotalSessionRevenueAsync(Guid userId)
        {
            try
            {
                var totalSessionRevenue = await _context.Payments
                    .Join(
                        _context.AttestedSessions,
                        payment => payment.AttestId,
                        attestedSession => attestedSession.AttestId,
                        (payment, attestedSession) => new
                        {
                            Type_Payment = payment.PaymentMode == 1 ? "Cash" :
                                           payment.PaymentMode == 2 ? "Bancontact" :
                                           payment.PaymentMode == 3 ? "Virement" :
                                           "Autre",
                            Type_b = payment.Payer == 1 ? "Patient" :
                                     payment.Payer == 4 ? "Mutuelle" :
                                     "Autre",
                            payment.Amount,
                            attestedSession.TotalAmount
                        })
                    .GroupBy(p => new { p.Type_b })
                    .Select(g => new
                    {
                        Type_b = g.Key.Type_b,
                        Total_a_facturer = g.Sum(p => p.TotalAmount)
                    })
                    .ToListAsync();

                return totalSessionRevenue;
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici
                throw ex;
            }
        }
        public async Task<IEnumerable<object>> GetBalanceByPayerAsync(Guid userId)
        {
            try
            {
                var balanceByPayer = await _context.Payments
                    .Join(_context.AttestedSessions,
                          payment => payment.AttestId,
                          attestedSession => attestedSession.AttestId,
                          (payment, attestedSession) => new
                          {
                              Type_Payment = payment.PaymentMode == 1 ? "Cash" :
                                             payment.PaymentMode == 2 ? "Bancontact" :
                                             payment.PaymentMode == 3 ? "Virement" :
                                             "Autre",
                              Type_b = payment.Payer == 1 ? "Patient" :
                                       payment.Payer == 4 ? "Mutuelle" :
                                       "Autre",
                              payment.Amount,
                              attestedSession.TotalAmount
                          })
                    .GroupBy(p => new { p.Type_b })
                    .Select(g => new
                    {
                        Type_b = g.Key.Type_b,
                        Solde_du = g.Sum(p => p.TotalAmount) - g.Sum(p => p.Amount)
                    })
                    .ToListAsync();

                return balanceByPayer;
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici
                throw ex;
            }
        }

    }
}
