
namespace Jasarsoft.Multiplayer
{
    internal class ServerDefault
    {
        private readonly string name;
        private readonly string address;
        private readonly string comment;


        public ServerDefault()
        {
            this.name = "localhost";
            this.address = "127.0.0.1";
            this.comment = "default host";
        }


        public string Name
        {
            get { return this.name; }
        }

        public string Address
        {
            get { return this.address; }
        }

        public string Comment
        {
            get { return this.comment; }
        }
    }
}
