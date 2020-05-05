using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoonlv5
{
    interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
