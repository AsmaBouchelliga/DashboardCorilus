using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DashBoard1.Data;
using DashBoard1.Models;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly AppDbContext _context;

        public PaymentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<object>> GetTotalPaymentsAsync(Guid userId)
        {
            try
            {
                var totalPayments = await _context.Payments
                    .Where(p => p.PaymentMode != -1)
                    .Select(p => new
                    {
                        Type_Payment = p.PaymentMode == 1 ? "Cash" :
                                       p.PaymentMode == 2 ? "Bancontact" :
                                       p.PaymentMode == 3 ? "Virement" :
                                       "Autre",
                        p.Amount
                    })
                    .ToListAsync();

                var groupedPayments = totalPayments.GroupBy(p => p.Type_Payment)
                                                   .Select(g => new
                                                   {
                                                       Type_Payment = g.Key,
                                                       paiement_recu = g.Sum(p => p.Amount)
                                                   })
                                                   .OrderBy(p => p.Type_Payment); // Tri par ordre alphabétique du type de paiement

                return groupedPayments;
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici
                throw ex;
            }
        }



    }
}
