using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF02
{
    public class OrganizerProfile
    {
        public int Id { get; set; }

        public string Bio { get; set; }
        public string Website { get; set; }
        public string Logo { get; set; }

        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }
    }
}
