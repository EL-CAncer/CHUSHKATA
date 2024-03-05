namespace CHUSHKA.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using CHUSHKA.Data.Models;
    using CHUSHKA.Services.Models;

    public interface IOrdersService
    {
        Task Create(string productId, string username);

        Task<IEnumerable<OrderServiceModel>> GetAll();
    }
}