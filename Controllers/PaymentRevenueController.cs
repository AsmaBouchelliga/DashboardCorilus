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
        //graphe1
        public class RevenueByPayerDto
        {
            public string Type_b { get; set; }
            public decimal Chiffre_Affaire { get; set; }
        }

        [HttpGet("revenue-by-payer/{userId}")]
        public async Task<IActionResult> GetRevenueByPayerAsync(Guid userId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var revenueByPayer = await _paymentRevenueService.GetRevenueByPayerAsync(userId, startDate, endDate);
                return Ok(revenueByPayer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite : {ex.Message}");
            }
        }

        
        //graphe4
        public class TotalSessionRevenueDto
        {
            public string Type_b { get; set; }
            public decimal Total_a_facturer { get; set; }
        }

        [HttpGet("total-session-revenue/{userId}")]
        public async Task<IActionResult> GetTotalSessionRevenueAsync(Guid userId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var totalSessionRevenue = await _paymentRevenueService.GetTotalSessionRevenueAsync(userId, startDate, endDate);
                return Ok(totalSessionRevenue);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite : {ex.Message}");
            }
        }

       
        //graphe 3
        public class BalanceByPayerDto
        {
            public string Type_b { get; set; }
            public decimal Solde_du { get; set; }
        }

        [HttpGet("balance-by-payer/{userId}")]
        public async Task<IActionResult> GetBalanceByPayerAsync(Guid userId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var balanceByPayer = await _paymentRevenueService.GetBalanceByPayerAsync(userId, startDate, endDate);
                return Ok(balanceByPayer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite : {ex.Message}");
            }
        }
    }
}
