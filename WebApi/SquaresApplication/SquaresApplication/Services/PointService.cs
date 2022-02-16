using Microsoft.EntityFrameworkCore;
using SquaresApplication.Data;
using SquaresApplication.Models;
using System;
using System.Collections.Generic;
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
            _dataContext.Points.Add(point);
            await _dataContext.SaveChangesAsync();
            return point;
        }
    }
}
