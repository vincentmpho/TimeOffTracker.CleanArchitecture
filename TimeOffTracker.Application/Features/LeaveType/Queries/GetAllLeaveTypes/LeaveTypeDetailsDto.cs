using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOffTracker.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{
    public class LeaveTypeDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DefaultDays  { get; set; }
        public DateTime DateCreated  { get; set; }
        public DateTime DateModified  { get; set; }
    }
}
