using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DashBoard1.Data;
using DashBoard1.Models;
using Microsoft.EntityFrameworkCore;
using static DashBoard1.Controllers.PaymentController;

namespace DashBoard1.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly AppDbContext _context;

        public PaymentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PaymentDto>> GetTotalPaymentsAsync(Guid userId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var totalPayments = await _context.Payments
                    .Where(p => p.PaymentMode != -1 && p.PaymentDate >= startDate && p.PaymentDate <= endDate)
                    .Select(p => new
                    {
                        TypePayment = p.PaymentMode == 1 ? "Cash" :
                                      p.PaymentMode == 2 ? "Bancontact" :
                                      p.PaymentMode == 3 ? "Virement" :
                                      "Autre",
                        p.Amount
                    })
                    .ToListAsync();

                var groupedPayments = totalPayments.GroupBy(p => p.TypePayment)
                                                   .Select(g => new PaymentDto
                                                   {
                                                       TypePayment = g.Key,
                                                       PaiementRecu = g.Sum(p => p.Amount)
                                                   })
                                                   .OrderBy(p => p.TypePayment);

                return groupedPayments;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
