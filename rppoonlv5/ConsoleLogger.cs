using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoonlv5
{
    class ConsoleLogger
    {
        private static ConsoleLogger instance;
        public static ConsoleLogger GetInstance()
        {
            if (instance == null) {
                instance = new ConsoleLogger();
            }
            return instance;
        }
        public ReadOnlyCollection<List<string>> Log(ProxyConsoleLogger proxyConsoleLogger)
        {
            ReadOnlyCollection<List<string>> data = proxyConsoleLogger.GetData();
            return data;
        }
    }
}
