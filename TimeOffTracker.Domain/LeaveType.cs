using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeOffTracker.Domain.Common;

namespace TimeOffTracker.Domain
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays  { get; set; }
    }
}
