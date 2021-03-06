using Microsoft.AspNetCore.Mvc;
using SquaresApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresApplication.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PointController : ControllerBase
    {
        private PointService _pointService;
        public PointController(PointService pointService)
        {
            _pointService = pointService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _pointService.GetPointsAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Point point)
        {
            try
            {
                Point createdPoint = await _pointService.AddPointAsync(point);
                return Created("",createdPoint);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Value);
            }

        }
        [HttpDelete]
        public async Task<IActionResult> RemoveAll(List<Point> points)
        {
            await _pointService.RemoveAllAsync(points);
            return Ok("Points deleted");    
        }
        //[HttpDelete]
        //public async Task<IActionResult> RemovePoint(int x, int y)
        //{
        //    await _pointService.RemovePoint(x,y);
        //    return Ok("Point deleted");
        //}
    }
}
