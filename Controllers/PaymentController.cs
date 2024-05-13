using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DashBoard1.Services;
using DashBoard1.Models;

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

        [HttpGet("total-payments")]
        public async Task<ActionResult<IEnumerable<object>>> GetTotalPayments(Guid userId)
        {
            try
            {
                var totalPayments = await _paymentService.GetTotalPaymentsAsync((userId));
                return Ok(totalPayments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite lors de la récupération des données : {ex.Message}");
            }
        }
    }
}
