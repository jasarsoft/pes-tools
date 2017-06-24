using System;

namespace Jasarsoft.Multiplayer
{
    internal class Content
    {
        readonly string header;
        readonly string footer;

        public Content()
        {
            this.header = "### PES6 Tools: Multiplayer - Header";
            this.footer = "### PES6 Tools: Multiplayer - Footer";
        }

        public string Header
        {
            get { return this.header; }
        }

        public string Footer
        {
            get { return this.footer; }
        }
    }
}
