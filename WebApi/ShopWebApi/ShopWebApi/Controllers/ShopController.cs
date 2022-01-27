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
using ShopWebApi.Exeptions;
using FluentValidation;

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
            catch (IdException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Create(CreateShop createShop)
        {
            try
            {
                int createdShopId = _shopService.Create(createShop);
                return Created("", createdShopId);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateShop updateShop)
        {
            UpdateShopValidator validator = new UpdateShopValidator();
            ValidationResult results = validator.Validate(updateShop);
            if (!results.IsValid)
            {
                return BadRequest(results.ToString("-"));
            }
            try
            {
                _shopService.Update(id, updateShop);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (IdException ex)
            {
                return NotFound(ex.Message);
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
            catch (IdException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
