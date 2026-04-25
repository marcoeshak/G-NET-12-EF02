using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF02
{
    using System.ComponentModel.DataAnnotations;
    using System.Net;

    public class Attendee
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public  Address Address { get; set; }

        public  Badge Badge { get; set; }

        public ICollection<Registration> Registrations { get; set; }
    }
}
