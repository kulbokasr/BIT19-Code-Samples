using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SEBRatesApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SEBRatesApplication.Controllers
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
            Rate rate = new Rate();
            return View(rate);
        }
        
        public IActionResult Calculations(string datestring)
        {
            XElement xelement = XElement.Load("http://www.lb.lt/webservices/ExchangeRates/ExchangeRates.asmx/getExchangeRatesByDate?Date=20000105");
            IEnumerable<XElement> exchangeRates = xelement.Elements();
            List<Rate> rates = new List<Rate>();
            foreach (var item in exchangeRates)
            {
                Rate rate = new Rate();
                //rate.DateChosen = datestring;
                rate.Date = item.Element("date").Value;
                rate.Currency = item.Element("currency").Value;
                rate.Quantity = Int32.Parse(item.Element("quantity").Value);
                rate.ExRate = item.Element("rate").Value;
                rate.Unit = item.Element("unit").Value;
                rates.Add(rate);
            }
            return View(rates);
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
