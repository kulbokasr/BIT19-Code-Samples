using AutoMapper;
using ShopWebApi.Data;
using ShopWebApi.Dtos;
using ShopWebApi.Models;
using ShopWebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWebApi.Services
{
    public class ItemService 
    {
        private readonly DataContext _dataContext;
        private ItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public ItemService(DataContext dataContext, ItemRepository itemRepository, IMapper mapper)
        {
            _dataContext = dataContext;
            _itemRepository = itemRepository;
            _mapper = mapper;
        }
        public List<Item> GetAll()
        {
            List<Item> items = _itemRepository.GetAll();
            return items;
        }
        public Item GetById(int id)
        {
            Item item = _itemRepository.GetById(id);
            if (item == null)
            {
                throw new ArgumentException("Item with such Id does not exist");
            }
            return item;
        }
        public void Remove(int id)
        {
            Item item = GetById(id);
            _dataContext.Items.Remove(item);
            _dataContext.SaveChanges();
        }
        public int Create(CreateItem createItem)
        {
            bool doesShopExist = _dataContext.Shops.Select(x => x.Id).Contains(createItem.ShopId);
            if (doesShopExist == false)
            {
                throw new ArgumentException("Cannot assign to this shop as it does not exist");
            }
            var model = new Item();
            model = _mapper.Map<Item>(createItem);
            _dataContext.Items.Add(model);
            _dataContext.SaveChanges();
            return model.Id;
        }
        public void Update(int id, UpdateItem updateItem)
        {
            Item item = GetById(id);
            bool doesShopExist = _dataContext.Shops.Select(x => x.Id).Contains(updateItem.ShopId);
            if (doesShopExist == false)
            {
                throw new ArgumentException("Cannot assign to this shop as it does not exist");
            }
            item.Name = updateItem.Name;
            item.Price = updateItem.Price;
            item.ShopId = updateItem.ShopId;
            _dataContext.SaveChanges();

        }
    }
}
