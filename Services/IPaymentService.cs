namespace DashBoard1.Services
{
    public interface IPaymentService 
    {
        Task<IEnumerable<object>> GetTotalPaymentsAsync(Guid userId);
    }
}
