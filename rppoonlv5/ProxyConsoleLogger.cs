using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoonlv5
{
    class ProxyConsoleLogger:IDataset
    {   
        private Dataset dataset;
        private List<int> allowedIDs;
        public User user { private get; set; }
        public ProxyConsoleLogger(User user)
        {
            this.allowedIDs = new List<int>(new int[] { 0, 1 });
            this.user = user;
        }
        private bool AuthenticateUser()
        {
            return allowedIDs.Contains(this.user.ID);
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            ConsoleLogger.GetInstance().log("Time accessed: "+ DateTime.Now.ToString());
            if (this.AuthenticateUser())
            {
                if (this.dataset == null)
                {
                    this.dataset = new Dataset("csvfile.txt");
                }
                ConsoleLogger.GetInstance().log("Hello "+user.Name);
                return this.dataset.GetData();
            }
            ConsoleLogger.GetInstance().log("Access denied!");
            return null;
        }
    }
}
    