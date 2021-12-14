using System.Collections.Generic;

namespace Zoo.Models
{
    public class SponsorModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Amount { get; set; }
        public int ZooId { get; set; }
        public ZooModel Animal{get; set;} // razor kartais nepatogu nes reikia daug ka papildomo prisikurti. jei turesi animal, galesi is jo atvaizduoti
        public  List<ZooModel> Animals { get; set; }
        public SponsorModel(List<ZooModel> animals)
        {
            Animals = animals;
        }
        public SponsorModel()
        {
            Animals = new List<ZooModel>();
        }
    }
}
