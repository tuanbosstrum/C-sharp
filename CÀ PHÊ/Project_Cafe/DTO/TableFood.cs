namespace DTO
{
    public class TableFood
    {
        private int id;
        private string name;
        private string status;

        public TableFood()
        {
        }

        public TableFood(int id, string name, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
    }
}
