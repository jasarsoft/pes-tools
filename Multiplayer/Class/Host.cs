﻿using System;
using System.IO;
using System.Collections.Generic;

namespace Jasarsoft.PES6Tools.Multiplayer
{
    internal class Host
    {
        string path;
        List<string> server;

        public Host()
        {
            server = new List<string>();
            path = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\drivers\etc\hosts";
        }

        public string Path
        {
            get { return this.path; }
        }

        public List<string> Server
        {
            get { return this.server; }
            set { this.server = value; }
        }

        public bool Check()
        {
            return !String.IsNullOrEmpty(this.path) && File.Exists(this.path);
        }

        public bool Valid()
        {
            string line;
            Content content = new Content();

            try
            {
                using (StreamReader sr = new StreamReader(this.path))
                {
                    do
                    {
                        line = sr.ReadLine();
                        if (line.StartsWith(content.Header) && line.Length == content.Header.Length)
                        {
                            do
                            {
                                line = sr.ReadLine();
                                if (line.StartsWith(content.Footer) && line.Length == content.Footer.Length) return true;
                            } while (!sr.EndOfStream);
                        }
                    } while (!sr.EndOfStream);
                }
            }
            catch (Exception)
            {
                //return false;
            }
                        
            return false;
        }

        public bool Read()
        {
            string line;
            this.server.Clear();
            Content content = new Content();

            try
            {
                using (StreamReader sr = new StreamReader(this.path))
                {
                    do
                    {
                        line = sr.ReadLine();
                        if (line.StartsWith(content.Header) && line.Length == content.Header.Length)
                        {
                            do
                            {
                                line = sr.ReadLine();
                                if (line.StartsWith(content.Footer) && line.Length == content.Footer.Length)
                                    return true;
                                else
                                    this.server.Add(line);
                            } while (!sr.EndOfStream);
                        }
                    } while (!sr.EndOfStream);
                }
            }
            catch (Exception)
            {
                //return false;
            }
            
            return false;
        }

        public bool Write()
        {
            string line;
            bool done = false;
            Content content = new Content();
            List<string> text = new List<string>();

            if(!File.Exists(this.path))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(this.path))
                    {
                        sw.WriteLine(content.Header);
                        foreach (string name in this.server) sw.WriteLine(name);
                        sw.WriteLine(content.Footer);
                        done = true;
                    }
                }
                catch (Exception)
                {
                    done = false;
                }

                return done;
            }

            try
            {
                using (StreamReader sr = new StreamReader(this.path))
                {
                    do
                    {
                        line = sr.ReadLine();
                        if (line.StartsWith(content.Header) && line.Length == content.Header.Length)
                        {
                            text.Add(line);
                            do
                            {
                                line = sr.ReadLine();
                                if (line.StartsWith(content.Footer) && line.Length == content.Footer.Length)
                                {
                                    foreach (string name in this.server) text.Add(name);
                                    text.Add(line);
                                    done = true;
                                }
                            } while (!done || !sr.EndOfStream);
                        }
                        else text.Add(line);
                    } while (!sr.EndOfStream);
                }

                if (!done)
                {
                    text.Add("");
                    text.Add(content.Header);
                    foreach (string name in this.server) text.Add(name);
                    text.Add(content.Footer);
                    done = true;
                }

                using (StreamWriter sw = new StreamWriter(this.path))
                {
                    foreach (string name in text) sw.WriteLine(name);
                    done = true;
                }
            }
            catch (Exception)
            {
                done = false;
            }

            return done;
        }


        private List<string> ReadServer(string path, string header, string footer)
        {
            string line;
            bool finish = false;
            List<string> servers = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    do
                    {
                        line = sr.ReadLine();
                        if (line.StartsWith(header) && line.Length == header.Length)
                        {
                            do
                            {
                                line = sr.ReadLine();
                                if (line.StartsWith(footer) && line.Length == footer.Length)
                                    finish = true;
                                else
                                    servers.Add(line);
                            } while (!sr.EndOfStream || !finish);
                        }
                    } while (!sr.EndOfStream || !finish);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return servers;
        }
    }
}
