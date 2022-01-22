namespace DTO
{
    public class Staff
    {
        private int id;
        private string fullname;
        private string phone;
        private string address;
        private string namelevel;

        public int Id { get => id; set => id = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Namelevel { get => namelevel; set => namelevel = value; }


        public Staff()
        {

        }
        public Staff(int id, string fullname, string phone, string address, string namelevel)
        {
            this.id = id;
            this.fullname = fullname;
            this.phone = phone;
            this.address = address;
            this.namelevel = namelevel;

        }



    }
}
