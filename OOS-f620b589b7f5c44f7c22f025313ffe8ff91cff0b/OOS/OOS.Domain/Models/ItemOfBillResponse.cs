using System;
using System.Collections.Generic;
using System.Text;

namespace OOS.Domain.Categories.Models
{
    class ItemOfBillResponse
    {
        public string IdFood { get; set; }

        public string NameCategory { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public int TotalPrice { get; set; }
    }
}
