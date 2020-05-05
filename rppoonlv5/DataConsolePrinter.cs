using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoonlv5
{
    class DataConsolePrinter
    {
        public void Log(IDataset dataset)
        {
            ReadOnlyCollection<List<string>> output = dataset.GetData();
            if (output != null)
            {
                foreach (List< string > item in output)
                {
                    foreach (var obj in item)
                    {
                        Console.Write(obj + " ");
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("there is no data!");
        }
    }
}
