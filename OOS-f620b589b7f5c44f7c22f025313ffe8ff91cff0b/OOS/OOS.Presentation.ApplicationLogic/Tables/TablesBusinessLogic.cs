using AutoMapper;
using MongoDB.Driver;
using OOS.Infrastructure.Mongodb;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OOS.Domain.Categories.Models;
using OOS.Presentation.ApplicationLogic.Tables.Messages;
using OOS.Domain.Tables.Models;

namespace OOS.Presentation.ApplicationLogic.Tables
{
    public class TablesBusinessLogic : ITablesBusinessLogic
    {
        private readonly IMapper _mapper;
        private readonly IMongoDbRepository _mongoDbRepository;

        public TablesBusinessLogic(IMapper mapper, IMongoDbRepository mongoDbRepository)
        {
            _mapper = mapper;
            _mongoDbRepository = mongoDbRepository;
        }

        public List<Table> GetTables()
        {
            var filter = Builders<Table>.Filter.Empty;
            var listTables = _mongoDbRepository.Find(filter).ToList();
            return listTables;
        }

        public GetTableResponse GetTable(string idTable)
        {
            Table _table= _mongoDbRepository.Get<Table>(idTable);
            GetTableResponse table = new GetTableResponse();
            table = _mapper.Map<Table, GetTableResponse>(_table);
            foreach (var item in table.ItemsOfBill)
            {
                table.Total += item.TotalPrice;
            }
            return table;

        }

        public CreateTableResponse CreateTable(Table table)
        {
            _mongoDbRepository.Create(table);
            var result = _mapper.Map<Table, CreateTableResponse>(table);
            return result;
        }

        public EditTableResponse EditTable(string Id, Table table)
        {
            table.Id = Id;

            _mongoDbRepository.Replace<Table>(table);

            var result = _mapper.Map<Table, EditTableResponse>(table);
            return result;
        }

        public void DeleteTable(string id)
        {
            var table = _mongoDbRepository.Get<Table>(id);
            _mongoDbRepository.Delete(table);
        }
    }
}