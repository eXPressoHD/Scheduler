using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class WorkingDay
    {
        public DateTime Date { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public DateTime BreakFrom { get; set; }
        public DateTime BreakTo { get; set; }
        public DateTime Overflow { get; set; }
        public DateTime WorkHours { get; set; }
        public string Notes { get; set; }
        public bool Holiday { get; set; }
        public int AvailableHolidays { get; set; }

    }
}
