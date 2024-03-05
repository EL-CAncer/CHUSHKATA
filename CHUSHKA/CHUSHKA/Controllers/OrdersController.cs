namespace CHUSHKA.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
   
    using CHUSHKA.wwwroot.Mapping;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using AutoMapper;
    using Services.Contracts;
    using CHUSHKA.wwwroot;
    using CHUSHKA.Models;

    public class OrdersController : Controller
    {
        private readonly IOrdersService ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        [Authorize]
        public async Task<IActionResult> Create(string id)
        {
            await this.ordersService.Create(id, this.User.Identity.Name);

            return this.RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = GlobalConstants.AdminRoleName)]
        public async Task<IActionResult> All()
        {
            var orders = (await this.ordersService.GetAll())
                .Select(Mapper.Map<OrderListViewModel>)
                .ToArray();

            return this.View(orders);
        }
    }
}