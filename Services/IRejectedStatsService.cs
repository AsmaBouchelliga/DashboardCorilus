using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static DashBoard1.Controllers.RejectedStatsController;

namespace DashBoard1.Services
{
    public interface IRejectedStatsService
    {
        Task<(int nbAttest, decimal montantTotalAttestedSessions, int nbInvoices, decimal montantTotalElectronicInvoices)> GetCombinedReportAsync(Guid userId, DateTime startDate, DateTime endDate);
        Task<IEnumerable<NomenclatureStatsDto>> GetTop10NomenclatureStatsAsync(Guid userId, DateTime startDate, DateTime endDate);
    }
}
