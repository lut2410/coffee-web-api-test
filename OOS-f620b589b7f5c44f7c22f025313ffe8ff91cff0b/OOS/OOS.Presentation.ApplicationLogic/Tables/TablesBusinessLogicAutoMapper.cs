using AutoMapper;
using OOS.Domain.Tables.Models;
using OOS.Presentation.ApplicationLogic.Tables.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOS.Presentation.ApplicationLogic.Tables
{
    public class TablesBusinessLogicAutoMapper : Profile
    {
        public TablesBusinessLogicAutoMapper()
        {
            CreateMap<Table, GetTableResponse>();
            CreateMap<Table, CreateTableResponse>();
            CreateMap<Table, EditTableResponse>();
        }
    }
}
