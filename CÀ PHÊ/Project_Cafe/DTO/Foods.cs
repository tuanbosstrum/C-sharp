namespace DTO
{
    public class Foods
    {
        private int idFood;
        private string nameFood;
        private double priceFood;
        private string imageFood;
        private int id_categoryFood;

        public Foods()
        {
        }

        public Foods(int idFood, string nameFood, double priceFood, string imageFood, int id_categoryFood)
        {
            this.IdFood = idFood;
            this.NameFood = nameFood;
            this.PriceFood = priceFood;
            this.ImageFood = imageFood;
            this.Id_categoryFood = id_categoryFood;
        }

        public int IdFood { get => idFood; set => idFood = value; }
        public string NameFood { get => nameFood; set => nameFood = value; }
        public double PriceFood { get => priceFood; set => priceFood = value; }
        public string ImageFood { get => imageFood; set => imageFood = value; }
        public int Id_categoryFood { get => id_categoryFood; set => id_categoryFood = value; }
    }
}
