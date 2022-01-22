namespace DTO
{
    public class ItemBill
    {
        private string foodName;
        private int count;
        private double price;

        public ItemBill()
        {
        }

        public ItemBill(string foodName, int count, double price)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public double Price { get => price; set => price = value; }
    }
}
