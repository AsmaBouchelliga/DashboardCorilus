using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using DashBoard1.Services;
using DashBoard1.Models;

namespace DashBoard1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RejectedStatsController : ControllerBase
    {
        private readonly IRejectedStatsService _rejectedStatsService;

        public RejectedStatsController(IRejectedStatsService rejectedStatsService)
        {
            _rejectedStatsService = rejectedStatsService;
        }

        [HttpGet("rejected-attestations")]
        public async Task<IActionResult> GetRejectedAttestationsAsync(Guid userId)
        {
            try
            {
                var (count, totalAmount) = await _rejectedStatsService.GetRejectedAttestationsAsync(userId);
                return Ok(new { Count = count, TotalAmount = totalAmount });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite : {ex.Message}");
            }
        }

        [HttpGet("rejected-invoices")]
        public async Task<IActionResult> GetRejectedInvoicesAsync(Guid userId)
        {
            try
            {
                var (count, totalAmount) = await _rejectedStatsService.GetRejectedInvoicesAsync(userId);
                return Ok(new { Count = count, TotalAmount = totalAmount });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite : {ex.Message}");
            }
        }
        [HttpGet("top-10-nomenclature-stats")]
        public async Task<IActionResult> GetTop10NomenclatureStatsAsync(Guid userId)
        {
            try
            {
                var topNomenclatureStats = await _rejectedStatsService.GetTop10NomenclatureStatsAsync(userId);
                return Ok(topNomenclatureStats);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite : {ex.Message}");
            }
        }
    }
}
