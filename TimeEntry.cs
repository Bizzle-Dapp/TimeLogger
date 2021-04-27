using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLogger
{
    public enum TimeEntryTask
    {
        Project,
        Meeting,
        Holiday,
        Training,
        SystemIssue,
        Break

    };

    public class TimeEntry
    {
        public string TaskName { get; set; }
        public TimeEntryTask TaskType { get; set; }
        public string TaskCode { get; set; }
        public double TimeSpent { get; set; }
        public DateTime? Date { get; set; } = new DateTime();
        public string Notes { get; set; }

    }
}
