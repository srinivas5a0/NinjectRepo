using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tesco.store.scheduler.entities;

namespace tesco.store.scheduler.entities
{
    public class StoreServer : BaseEntity
    {
        public string StoreNumber { get; set; }
        public string StoreName { get; set; }
        public string IpAddress { get; set; }
    }
}
