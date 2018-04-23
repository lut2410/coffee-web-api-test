using OOS.Domain.CategoryFoods.Models;
using OOS.Infrastructure.Mongodb;
using OOS.Presentation.ApplicationLogic.CategoryFoods.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOS.Presentation.ApplicationLogic.CategoryFoods
{
    public interface ICategoryFoodsBusinessLogic
    {
        List<CategoryFood> GetCategoryFoods();

        CategoryFood GetCategoryFood(string id);

        CreateCategoryFoodResponse CreateCategoryFood(CategoryFood cf);

        EditCategoryFoodResponse EditCategoryFood(string Id, CategoryFood cf);

        void DeleteCategoryFood(string id);
    }
}
