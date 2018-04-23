using AutoMapper;
using OOS.Domain.CategoryFoods.Models;
using OOS.Presentation.ApplicationLogic.CategoryFoods.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOS.Presentation.ApplicationLogic.CategoryFoods
{
    public class CategoryFoodsBusinessLogicAutoMapper : Profile
    {
        public CategoryFoodsBusinessLogicAutoMapper()
        {
            CreateMap<CategoryFood, CreateCategoryFoodResponse>();
            CreateMap<CategoryFood, EditCategoryFoodResponse>();
        }
    }
}
