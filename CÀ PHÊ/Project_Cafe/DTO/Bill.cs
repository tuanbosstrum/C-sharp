using System;

namespace DTO
{
    public class Bill
    {
        private int id;
        private DateTime dateCheckIn;
        private DateTime dateCheckOut;
        private int idTable;
        private int status;
        private double total;
        private string nametable;

        public Bill()
        {
        }

        public Bill(int id, DateTime dateCheckIn, DateTime dateCheckOut, int idTable, int status)
        {
            this.Id = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.IdTable = idTable;
            this.Status = status;
        }

        public Bill(int id, DateTime dateCheckIn, DateTime dateCheckOut, double total, string nametable)
        {
            this.id = id;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            this.total = total;
            this.nametable = nametable;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int Status { get => status; set => status = value; }
        public double Total { get => total; set => total = value; }
        public string Nametable { get => nametable; set => nametable = value; }
    }
}
