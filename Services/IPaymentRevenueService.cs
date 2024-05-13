namespace DashBoard1.Services
{
    public interface IPaymentRevenueService
    {
        Task<IEnumerable<object>> GetRevenueByPayerAsync(Guid userId);
        Task<IEnumerable<object>> GetTotalSessionRevenueAsync(Guid userId);
        Task<IEnumerable<object>> GetBalanceByPayerAsync(Guid userId);
    }
}
