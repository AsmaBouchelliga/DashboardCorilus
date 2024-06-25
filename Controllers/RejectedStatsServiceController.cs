using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DashBoard1.Services;

namespace DashBoard1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RejectedStatsController : ControllerBase
    {
        private readonly IRejectedStatsService _rejectedStatsService;

        public RejectedStatsController(IRejectedStatsService rejectedStatsService)
        {
            _rejectedStatsService = rejectedStatsService;
        }

        public class CombinedReportDto
        {
            public int NbAttest { get; set; }
            public decimal MontantTotalAttestedSessions { get; set; }
            public int NbInvoices { get; set; }
            public decimal MontantTotalElectronicInvoices { get; set; }
        }

        [HttpGet("combined-report")]
        public async Task<IActionResult> GetCombinedReport(Guid userId, DateTime startDate, DateTime endDate)
        {
            var result = await _rejectedStatsService.GetCombinedReportAsync(userId, startDate, endDate);
            return Ok(new CombinedReportDto
            {
                NbAttest = result.nbAttest,
                MontantTotalAttestedSessions = result.montantTotalAttestedSessions,
                NbInvoices = result.nbInvoices,
                MontantTotalElectronicInvoices = result.montantTotalElectronicInvoices
            });
        }
        public class NomenclatureStatsDto
        {
            public string NomenclatureCode { get; set; }
            public int Nombre { get; set; }
            public decimal MontantTotal { get; set; }
        }


        [HttpGet("top-nomenclature-stats")]
        public async Task<ActionResult<IEnumerable<NomenclatureStatsDto>>> GetTop10NomenclatureStats(Guid userId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var result = await _rejectedStatsService.GetTop10NomenclatureStatsAsync(userId, startDate, endDate);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite lors de la récupération des données : {ex.Message}");
            }
        }



    }
}
