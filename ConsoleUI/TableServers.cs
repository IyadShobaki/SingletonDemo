using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class TableServers
    {
        private static readonly TableServers _instance = new TableServers();
        private List<string> servers = new List<string>();
        private int nextServer = 0;

        private TableServers()
        {
            servers.Add("Iyad");
            servers.Add("Tim");
            servers.Add("Sue");
            servers.Add("Mary");
        }

        public static TableServers GetTableServers()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            string output = servers[nextServer];

            nextServer += 1;
            if (nextServer >= servers.Count)
            {
                nextServer = 0;
            }

            return output;
        }
    }
}


// Code before applying Singleton Design Pattern

//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleUI
//{
//    public class TableServers
//    {
//        private List<string> servers = new List<string>();
//        private int nextServer = 0;

//        public TableServers()
//        {
//            servers.Add("Iyad");
//            servers.Add("Tim");
//            servers.Add("Sue");
//            servers.Add("Mary");
//        }

//        public string GetNextServer()
//        {
//            string output = servers[nextServer];

//            nextServer += 1;
//            if (nextServer >= servers.Count)
//            {
//                nextServer = 0;
//            }

//            return output;
//        }
//    }
//}
