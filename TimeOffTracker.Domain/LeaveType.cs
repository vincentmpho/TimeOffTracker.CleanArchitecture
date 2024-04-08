using TimeOffTracker.Domain.Common;

namespace TimeOffTracker.Domain
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays  { get; set; }
    }
}
