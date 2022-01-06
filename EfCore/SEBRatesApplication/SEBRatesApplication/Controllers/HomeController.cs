using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SEBRatesApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
        
        public IActionResult Calculations(DateTime datestring)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = ",";
            var datestringchosen = datestring.ToShortDateString().Replace("-", "");
            var datestringnext = datestring.AddDays(-1).ToShortDateString().Replace("-", "");
            string linkchosen = "http://www.lb.lt/webservices/ExchangeRates/ExchangeRates.asmx/getExchangeRatesByDate?Date=" + datestringchosen;
            string linknext = "http://www.lb.lt/webservices/ExchangeRates/ExchangeRates.asmx/getExchangeRatesByDate?Date=" + datestringnext;

            XElement xelement = XElement.Load(linkchosen);
            IEnumerable<XElement> exchangeRates = xelement.Elements();
            List<Rate> rateschosen = new List<Rate>();
            foreach (var item in exchangeRates)
            {
                Rate rate = new Rate();
                rate.DateChosen = datestringchosen;
                rate.Date = item.Element("date").Value;
                rate.Currency = item.Element("currency").Value;
                rate.Quantity = Int32.Parse(item.Element("quantity").Value);
                rate.ExRate = Convert.ToDouble(item.Element("rate").Value, provider);
                rate.Unit = item.Element("unit").Value;
                rateschosen.Add(rate);
            }

            XElement xelement1 = XElement.Load(linknext);
            IEnumerable<XElement> exchangeRates1 = xelement1.Elements();
            List<Rate> ratesnext = new List<Rate>();
            foreach (var item in exchangeRates1)
            {
                Rate rate = new Rate();
                rate.DateChosen = datestringchosen;
                rate.Date = item.Element("date").Value;
                rate.Currency = item.Element("currency").Value;
                rate.Quantity = Int32.Parse(item.Element("quantity").Value);
                rate.ExRate = Convert.ToDouble(item.Element("rate").Value, provider);
                rate.Unit = item.Element("unit").Value;
                ratesnext.Add(rate);
            }

            for (int i = 0; i < rateschosen.Count; i++)
            {
                rateschosen[i].Difference = rateschosen[i].ExRate - ratesnext[i].ExRate;
            }

            List<Rate> orderedRates = new List<Rate>();
            orderedRates = rateschosen.OrderByDescending(o => o.Difference).ToList();

            return View(orderedRates);
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
