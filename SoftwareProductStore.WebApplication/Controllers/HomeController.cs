using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoftwareProductStore.Domain.Core;
using SoftwareProductStore.Domain.Interfaces;
using SoftwareProductStore.Services.Interfaces;

namespace SoftwareProductStore.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        IProductRepository productRepository;
        IOrder order;
        public HomeController(IProductRepository productRepository, IOrder order)
        {
            this.productRepository = productRepository;
            this.order = order;
        }
        public ActionResult Index()
        {
            var products = productRepository.GetProductList();
            return View(products);
        }
 
        public ActionResult Buy(int id)
        {
            Product product = productRepository.GetProductById(id);
            order.MakeOrder(product);
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            productRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}