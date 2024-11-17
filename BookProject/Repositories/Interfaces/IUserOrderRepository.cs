namespace BookProject.Repositories.Interfaces
{
    public interface IUserOrderRepository
    {
        Task<IEnumerable<Order>> UserOrders(DateTime? startDate, DateTime? endDate);
    }
}