namespace DashBoard1.Services
{
    public interface IRejectedStatsService
    {
        Task<(int, decimal)> GetRejectedAttestationsAsync(Guid userId);
        Task<(int, decimal)> GetRejectedInvoicesAsync(Guid userId);
        Task<IEnumerable<object>> GetTop10NomenclatureStatsAsync(Guid userId);
    }
}
