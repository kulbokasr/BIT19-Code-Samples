using Microsoft.AspNetCore.Mvc;
using ShopWebApi.Dtos;
using ShopWebApi.Services;
using ShopWebApi.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace ShopWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private ShopService _shopService;
        public ShopController(ShopService shopService)
        {
            _shopService = shopService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_shopService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_shopService.GetById(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Create(CreateShop createShop)
        {
            ShopValidator validator = new ShopValidator();
            ValidationResult results = validator.Validate(createShop);
            if (!results.IsValid)
            {
                return BadRequest(results.ToString("-"));
            }
            try
            {
                int createdShopId = _shopService.Create(createShop);
                return Created("", createdShopId);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateShop updateShop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _shopService.Update(id, updateShop);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok("Shop Updated");
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            try
            {
                _shopService.Remove(id);
                return Ok("Shop deleted");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
