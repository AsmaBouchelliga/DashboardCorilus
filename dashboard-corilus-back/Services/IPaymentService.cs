using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static DashBoard1.Controllers.PaymentController;

namespace DashBoard1.Services
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentDto>> GetTotalPaymentsAsync(Guid userId, DateTime startDate, DateTime endDate);
    }
}
