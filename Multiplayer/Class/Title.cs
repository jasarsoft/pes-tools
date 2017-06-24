
namespace Jasarsoft.Multiplayer
{
    internal class Title
    {
        private readonly string titleInfo;
        private readonly string titleError;
        private readonly string titleWarning;

        public Title()
        {
            About about = new About();

            this.titleInfo = about.Title + " | Information";
            this.titleError = about.Title + " | Error";
            this.titleWarning = about.Title + " | Warning";
        }

        public string Info
        {
            get { return this.titleInfo; }
        }

        public string Error
        {
            get { return this.titleError; }
        }

        public string Warning
        {
            get { return this.titleWarning; }
        }
    }
}
