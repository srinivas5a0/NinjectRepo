using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tesco.store.scheduler.entities;

namespace tesco.store.scheduler.entities
{
    public class Project : BaseEntity
    {
        public string ProjectName { get; set; }
        public string ProjectScheduledBy { get; set; }
        public string RolloutManager { get; set; }
        public int RolloutNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<ScheduleDetail> ScheduleDetails { get; set; }
    }
}
