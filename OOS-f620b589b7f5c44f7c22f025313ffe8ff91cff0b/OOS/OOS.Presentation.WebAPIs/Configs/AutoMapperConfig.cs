using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using OOS.Presentation.ApplicationLogic.CategoryFoods;
using OOS.Presentation.ApplicationLogic.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOS.Presentation.WebAPIs.Configs
{
    public class AutoMapperConfig
    {
        public static void Configure(IServiceCollection services)
        {
            var config = new MapperConfiguration(c =>
            {
                c.AddProfile<CategoryFoodsBusinessLogicAutoMapper>();
                c.AddProfile<TablesBusinessLogicAutoMapper>();

            });

            services.AddAutoMapper(n => config.CreateMapper());
        }
    }
}