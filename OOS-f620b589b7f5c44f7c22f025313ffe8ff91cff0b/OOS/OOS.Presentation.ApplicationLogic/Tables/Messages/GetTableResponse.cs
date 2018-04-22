using OOS.Domain.Tables.Models;
using OOS.Presentation.ApplicationLogic.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOS.Presentation.ApplicationLogic.Tables.Messages
{
    public class GetTableResponse : ResponseBase
    {
        public string Id { get; set; }

        public int Status { get; set; }

        public ItemOfBill[] ItemsOfBill { get; set; }

        public int Total{get;set;}
    }
}