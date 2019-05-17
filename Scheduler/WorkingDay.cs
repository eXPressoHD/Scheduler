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
        public DateTime WorkTime { get; set; }
        public string Notes { get; set; }
        public bool Holiday { get; set; }
        public int AvailableHolidays { get; set; }

        //Initialize with all nessessary columns
        public WorkingDay(DateTime date, DateTime from, DateTime to, DateTime breakFrom, DateTime breakTo, DateTime overflow, DateTime workTime, bool holiday)
        {
            Date = date;
            From = from;
            To = to;
            BreakFrom = breakFrom;
            BreakTo = breakTo;
            Overflow = overflow;
            WorkTime = workTime;
            Holiday = holiday;
        }

    }
}
