
namespace Jasarsoft.Multiplayer
{
    static internal class Server
    {
        private static string name;
        private static string address;
        private static string comment;

        public Server()
        {
            name = null;
            address = null;
            comment = null;
        }


        public static string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static string Address
        {
            get { return address; }
            set { address = value; }
        }

        public static string Comment
        {
            get { return comment; }
            set { comment = value; }
        }


        public static void Default()
        {
            ServerDefault sd = new ServerDefault();

            name = sd.Name;
            address = sd.Address;
            comment = sd.Comment;
        }
    }
}
