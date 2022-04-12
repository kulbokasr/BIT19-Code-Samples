using CacheTask.Data;
using CacheTask.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.SqlServer;
using CacheTask.Services;

namespace CacheTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HangfireTest : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly SomeService _SomeService;

        public HangfireTest(DataContext dataContext, SomeService someService)
        {
            _dataContext = dataContext;
            _SomeService = someService;
        }

        [HttpGet]
        public List<SomeModel> GetAll()
        {

            List<SomeModel> someInfo = _dataContext.SomeInfo.ToList();
            RecurringJob.AddOrUpdate("myrecurringjob",() => _SomeService.CreateAsync(),Cron.Minutely);
            return someInfo;

        }
    }
}
