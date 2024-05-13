using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using DashBoard1.Services;

namespace DashBoard1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentRevenueController : ControllerBase
    {
        private readonly IPaymentRevenueService _paymentRevenueService;

        public PaymentRevenueController(IPaymentRevenueService paymentRevenueService)
        {
            _paymentRevenueService = paymentRevenueService;
        }

        [HttpGet("revenue-by-payer")]
        public async Task<IActionResult> GetRevenueByPayerAsync()
        {
            try
            {
                var revenueByPayer = await _paymentRevenueService.GetRevenueByPayerAsync();
                return Ok(revenueByPayer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite : {ex.Message}");
            }
        }
        [HttpGet("total-session-revenue")]
        public async Task<IActionResult> GetTotalSessionRevenueAsync()
        {
            try
            {
                var totalSessionRevenue = await _paymentRevenueService.GetTotalSessionRevenueAsync();
                return Ok(totalSessionRevenue);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite : {ex.Message}");
            }
        }
        [HttpGet("balance-by-payer")]
        public async Task<IActionResult> GetBalanceByPayerAsync(Guid userId)
        {
            try
            {
                var balanceByPayer = await _paymentRevenueService.GetBalanceByPayerAsync(userId);
                return Ok(balanceByPayer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite : {ex.Message}");
            }
        }
    }
}
