using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF02
{
    public class Badge
    {
        public int Id { get; set; }

        public string BadgeNumber { get; set; }
        public DateTime IssueDate { get; set; }

        public BadgeTier Tier { get; set; }

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    }

    public enum BadgeTier
    {
        Standard,
        VIP
    }
}
