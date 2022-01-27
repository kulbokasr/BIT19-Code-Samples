using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using ShopWebApi.Data;
using ShopWebApi.Dtos;
using ShopWebApi.Exeptions;
using ShopWebApi.Models;
using ShopWebApi.Repositories;
using ShopWebApi.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWebApi.Services
{
    public class ShopService
    {
        private readonly DataContext _dataContext;
        private ShopRepository _shopRepository;
        private readonly IMapper _mapper;

        public ShopService(DataContext dataContext, ShopRepository shopRepository, IMapper mapper)
        {
            _dataContext = dataContext;
            _shopRepository = shopRepository;
            _mapper = mapper;
        }
        public List<Shop> GetAll()
        {
            List<Shop> shops = _dataContext.Shops.Include("Items").ToList();
            return shops;
        }
        public Shop GetById(int id)
        {
            var shop = _dataContext.Shops.Include("Items").Where(i=> i.Id == id).FirstOrDefault();
            if (shop == null)
            {
                throw new IdException(id);
            }
            return shop;
        }
        public void Remove(int id)
        {
            Shop shop = GetById(id);
            _dataContext.Shops.Remove(shop);
            _dataContext.SaveChanges();
        }
        public int Create(CreateShop createShop)
        {
            bool doesNameExist = _dataContext.Shops.Select(x => x.Name).Contains(createShop.Name);
            if (doesNameExist)
            {
                throw new ArgumentException("Shop with such name already exists");
            }
            ShopValidator validator = new ShopValidator();
            validator.ValidateAndThrow(createShop);
            var model = new Shop();
            model = _mapper.Map<Shop>(createShop);
            _dataContext.Shops.Add(model);
            _dataContext.SaveChanges();
            return model.Id;
        }
        public void Update(int id, UpdateShop updateShop)
        {
            Shop shop = GetById(id);
            bool doesNameExist = _dataContext.Shops.Select(x => x.Name).Contains(updateShop.Name);
            if (doesNameExist)
            {
                throw new ArgumentException("Shop with such name already exists");
            }
           shop.Name = updateShop.Name;
            _dataContext.SaveChanges();

        }
    }
}
