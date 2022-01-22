namespace DTO
{
    public class Admin
    {
        private int id;
        private string displayname;
        private string username;
        private string password;
        private int level;

        public Admin()
        {
        }

        public Admin(int id, string displayname, string username, string password, int level)
        {
            this.id = id;
            this.displayname = displayname;
            this.username = username;
            this.password = password;
            this.level = level;
        }

        public int Id { get => id; set => id = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Level { get => level; set => level = value; }
    }
}
