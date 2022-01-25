using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using ShopWebApi.Dtos;
using ShopWebApi.Services;
using ShopWebApi.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private ItemService _itemService;
        public ItemController(ItemService itemService)
        {
            _itemService = itemService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_itemService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_itemService.GetById(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Create(CreateItem createItem)
        {
            ItemValidator validator = new ItemValidator();
            ValidationResult results = validator.Validate(createItem);
            if (!results.IsValid)
            {
                return BadRequest(results.ToString("-"));
            }
            try
            {
                int createdItemId = _itemService.Create(createItem);
                return Created("", createdItemId);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateItem updateItem)
        {
            UpdateItemValidator validator = new UpdateItemValidator();
            ValidationResult results = validator.Validate(updateItem);
            if (!results.IsValid)
            {
                return BadRequest(results.ToString("-"));
            }
            try
            {
                _itemService.Update(id, updateItem);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok("Item Updated");
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            try
            {
                _itemService.Remove(id);
                return Ok("Item deleted");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
