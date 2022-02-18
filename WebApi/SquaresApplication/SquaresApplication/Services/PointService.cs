using Microsoft.EntityFrameworkCore;
using SquaresApplication.Data;
using SquaresApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresApplication.Services
{
    public class PointService
    {
        private readonly DataContext _dataContext;

        public PointService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Point>> GetPointsAsync()
        {
            List<Point> points = await _dataContext.Points.ToListAsync();
            return points;
        }
        public async Task<Point> AddPointAsync(Point point)
        {
            bool doesPointExist = await _dataContext.Points.AnyAsync(p => p.X == point.X & p.Y == point.Y);
            if (doesPointExist)
            {
                throw new ArgumentException("Such point already exist");
            }
            //if (point.X > 50 || point.Y > 50)
            //{
            //    throw new ValidationException("sdgskdghdlghsgkjlshgkjshgksjdghskjdfhsdfjslhdfslkdhf");
            //}
            _dataContext.Points.Add(point);
            await _dataContext.SaveChangesAsync();
            return point;
        }
        public async Task RemoveAllAsync(List<Point> points)
        {
            _dataContext.Points.RemoveRange(points);
            await _dataContext.SaveChangesAsync();
        }
    }
}
