using AutoMapper;
using MongoDB.Driver;
using OOS.Infrastructure.Mongodb;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OOS.Presentation.ApplicationLogic.CategoryFoods.Messages;
using OOS.Domain.CategoryFoods.Models;

namespace OOS.Presentation.ApplicationLogic.CategoryFoods
{
    public class CategoryFoodsBusinessLogic : ICategoryFoodsBusinessLogic
    {
        private readonly IMapper _mapper;
        private readonly IMongoDbRepository _mongoDbRepository;

        public CategoryFoodsBusinessLogic(IMapper mapper, IMongoDbRepository mongoDbRepository)
        {
            _mapper = mapper;
            _mongoDbRepository = mongoDbRepository;
        }

        public List<CategoryFood> GetCategoryFoods()
        {
            var filter = Builders<CategoryFood>.Filter.Empty;
            var listCategoryFoods = _mongoDbRepository.Find(filter).ToList();
            return listCategoryFoods;
        }

        public CategoryFood GetCategoryFood(string idTable)
        {
            CategoryFood categoryFood = _mongoDbRepository.Get<CategoryFood>(idTable);
            return categoryFood;

        }

        public CreateCategoryFoodResponse CreateCategoryFood(CategoryFood cf)
        {
            _mongoDbRepository.Create(cf);
            var result = _mapper.Map<CategoryFood, CreateCategoryFoodResponse>(cf);
            return result;
        }

        public EditCategoryFoodResponse EditCategoryFood(string Id, CategoryFood table)
        {
            table.Id = Id;

            _mongoDbRepository.Replace<CategoryFood>(table);

            var result = _mapper.Map<CategoryFood, EditCategoryFoodResponse>(table);
            return result;
        }

        public void DeleteCategoryFood(string id)
        {
            var table = _mongoDbRepository.Get<CategoryFood>(id);
            _mongoDbRepository.Delete(table);
        }
    }
}