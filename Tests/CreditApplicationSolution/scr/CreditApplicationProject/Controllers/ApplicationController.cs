using CreditApplicationProject.Models;
using CreditApplicationProject.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicationController : ControllerBase
    {
        private readonly ApplicationService _applicationService;

        public ApplicationController(ApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        [HttpPost("/calculate")]
        public dynamic GetDecission(Application application)
        {
            try
            {
                return _applicationService.GetDecision(application);
            }
            catch (ArgumentException ex)
            {
               return BadRequest(ex.Message); ;
            }
        }
    }
}
