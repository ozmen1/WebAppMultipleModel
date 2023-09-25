using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;
using WebAppMultipleModel.Models;

namespace WebAppMultipleModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<SaleDetails> listOfSaleDetails = new List<SaleDetails>();
            listOfSaleDetails.Add(new SaleDetails() { Barcode = "123", CustomerName = "C1", SaleDate = DateTime.Now, SaleId = 1});
            listOfSaleDetails.Add(new SaleDetails() { Barcode = "345", CustomerName = "C2", SaleDate = DateTime.Now, SaleId = 2});
            listOfSaleDetails.Add(new SaleDetails() { Barcode = "456", CustomerName = "C3", SaleDate = DateTime.Now, SaleId = 3});
            listOfSaleDetails.Add(new SaleDetails() { Barcode = "567", CustomerName = "C4", SaleDate = DateTime.Now, SaleId = 4});
            
            List<SaleItems> listOfSaleItems = new List<SaleItems>();
            listOfSaleItems.Add(new SaleItems() { ItemName = "I1", SaleId = 1, Quantity = 1, UnitPrice = 100});
            listOfSaleItems.Add(new SaleItems() { ItemName = "I2", SaleId = 2, Quantity = 2, UnitPrice = 50 });
            listOfSaleItems.Add(new SaleItems() { ItemName = "I3", SaleId = 3, Quantity = 3, UnitPrice = 75 });
            listOfSaleItems.Add(new SaleItems() { ItemName = "I4", SaleId = 4, Quantity = 4, UnitPrice = 120 });

            //yeni bir model oluşturarak kombine etme
            //SaleViewModel objSaleViewModel = new SaleViewModel();
            //objSaleViewModel.SaleItemsViewModel = listOfSaleItems;
            //objSaleViewModel.SaleDetailsViewModel = listOfSaleDetails;
            //return View(objSaleViewModel);

            //viewdata kullanma
            //ViewData["SaleDetailsViewModel"] = listOfSaleDetails;
            //ViewData["SaleItemsViewModel"] = listOfSaleItems;
            //return View();

            //dynamic keyword kullanma
            //dynamic myDetailsItems = new ExpandoObject();
            //myDetailsItems.SaleDetails = listOfSaleDetails;
            //myDetailsItems.SaleItems = listOfSaleItems;
            //return View(myDetailsItems);

            //tuple kullanma
            var tupleSaleDetailsItems = new Tuple<List<SaleDetails>, List<SaleItems>>(listOfSaleDetails, listOfSaleItems);
            return View(tupleSaleDetailsItems);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}