using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DashBoard1.Services;

namespace DashBoard1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        public class PaymentDto
        {
            public string TypePayment { get; set; }
            public decimal PaiementRecu { get; set; }
        }

        [HttpGet("total-payments/{userId}")]
        public async Task<ActionResult<IEnumerable<PaymentDto>>> GetTotalPayments(Guid userId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var totalPayments = await _paymentService.GetTotalPaymentsAsync(userId, startDate, endDate);
                return Ok(totalPayments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite lors de la récupération des données : {ex.Message}");
            }
        }

    }
}
