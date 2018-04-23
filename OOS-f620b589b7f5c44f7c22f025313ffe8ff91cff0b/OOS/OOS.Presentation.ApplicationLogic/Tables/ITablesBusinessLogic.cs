using OOS.Domain.Tables.Models;
using OOS.Infrastructure.Mongodb;
using OOS.Presentation.ApplicationLogic.Tables.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOS.Presentation.ApplicationLogic.Tables
{
    public interface ITablesBusinessLogic
    {
        List<Table> GetTables();

        GetTableResponse GetTable(string idTable);

        CreateTableResponse CreateTable(Table table);

        EditTableResponse EditTable(string Id, Table table);

        void DeleteTable(string id);
    }
}
