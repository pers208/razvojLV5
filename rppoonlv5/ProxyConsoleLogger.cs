using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoonlv5
{
    class ProxyConsoleLogger
    {
        List<string> data;
        private string filePath="csvfile.txt";
        private Dataset dataset;
        public ProxyConsoleLogger(string filePath)
        {
            this.filePath = filePath;
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }

            data.Add("Data accessed : " + DateTime.Now.ToString());

            return dataset.GetData();
        }
        public void log(ProxyConsoleLogger proxyConsoleLogger)
        {
            Console.WriteLine(ConsoleLogger.GetInstance().Log(proxyConsoleLogger));
        }
    }
}
    