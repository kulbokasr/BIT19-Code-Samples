using System;

namespace SEBRatesApplication.Models
{
    public class Rate
    {
        public string Date { get; set; }
        public string Currency { get; set; }
        public int Quantity { get; set; }
        public double ExRate { get; set; }
        public string Unit { get; set; }
        public string DateChosen { get; set; }
        public double Difference { get; set; }
    }
}
