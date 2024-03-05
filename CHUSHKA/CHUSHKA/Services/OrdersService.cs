namespace CHUSHKA.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper.QueryableExtensions;
    using CHUSHKA.Data.Models;
    using CHUSHKA.Services.Contracts;
    using CHUSHKA.Services.Models;
    using Data;
    using Microsoft.EntityFrameworkCore;


    public class OrdersService : DataService, IOrdersService
    {
        public OrdersService(ChushkaDbContext context) : base(context)
        {
        }

        public async Task Create(string productId, string username)
        {
            var product = await this.context.Products.FirstOrDefaultAsync(p => p.Id == productId && !p.IsDeleted);

            var user = await this.context.Users.FirstOrDefaultAsync(u => u.UserName == username);

            if (product == null || user == null)
            {
                return;
            }

            var order = new Order
            {
                Client = (AppUser)user,
                Product = product,
                OrderedOn = DateTime.Now
            };

            await this.context.Orders.AddAsync(order);

            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<OrderServiceModel>> GetAll()
        {
            var orders = await this.context.Orders
                .ProjectTo<OrderServiceModel>()
                .ToArrayAsync();

            return orders;
        }

        Task<IEnumerable<OrderServiceModel>> IOrdersService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
