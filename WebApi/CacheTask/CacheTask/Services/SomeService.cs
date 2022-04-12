using CacheTask.Data;
using CacheTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheTask.Services
{
    public class SomeService
    {
        private readonly DataContext _dataContext;
        public SomeService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void CreateAsync()
        {
            var someInfo = new SomeModel()
            {
                Name = "some name"
            };
            _dataContext.SomeInfo.Add(someInfo);
            _dataContext.SaveChanges();
            KeyModel keyModel = new KeyModel()
            {
                Key = "labas"
            };
            ValueModel valueModel = new ValueModel()
            {
                Value = "sfsdfsdf",
                Id = 1,
                KeyModelKey = "test"
            };
            Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();
            keyValuePairs.Add(keyModel.Key, valueModel.Value);
           
        }
    }
}
