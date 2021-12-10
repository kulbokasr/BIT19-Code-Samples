using FirstMvcApplication.Models;
using System.Collections.Generic;

namespace FirstMvcApplication.Services
{
    public class DataService
    {
        private List<PersonModel> persons = new List<PersonModel>();
        public List<PersonModel> GetAll()
        {
            return persons;
        }
        public void Add(PersonModel personModel)
        {
            persons.Add(personModel);
        }
    }
}
