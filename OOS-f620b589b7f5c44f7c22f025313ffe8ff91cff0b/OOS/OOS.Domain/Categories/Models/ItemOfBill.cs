namespace OOS.Domain.Tables.Models
{
    public class ItemOfBill
    {
        public string IdFood { get; set; }

        public string NameCategory { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public int TotalPrice { get; set; }
    }
}