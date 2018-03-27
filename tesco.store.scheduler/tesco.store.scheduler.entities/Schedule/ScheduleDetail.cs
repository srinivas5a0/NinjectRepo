using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tesco.store.scheduler.entities;

namespace tesco.store.scheduler.entities
{
    public class ScheduleDetail : BaseEntity
    {
        public DateTime ScheduledOn { get; set; }
        public List<StoreServer> ScheduledStores { get; set; }
    }
}
