using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesco.store.scheduler.entities.StoreServers.ViewModels
{
    public class StoreServerViewModel
    {
        public long id { get; set; }
        public string StoreNumber { get; set; }
        public string IpAddress { get; set; }
    }
}
