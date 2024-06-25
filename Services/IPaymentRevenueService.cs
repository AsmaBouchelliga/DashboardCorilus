using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static DashBoard1.Controllers.PaymentRevenueController;

namespace DashBoard1.Services
{
    public interface IPaymentRevenueService
    {
        Task<IEnumerable<RevenueByPayerDto>> GetRevenueByPayerAsync(Guid userId, DateTime startDate, DateTime endDate);
        Task<IEnumerable<TotalSessionRevenueDto>> GetTotalSessionRevenueAsync(Guid userId, DateTime startDate, DateTime endDate);
        Task<IEnumerable<BalanceByPayerDto>> GetBalanceByPayerAsync(Guid userId, DateTime startDate, DateTime endDate);
    }
}
