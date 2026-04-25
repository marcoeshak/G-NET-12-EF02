using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF02
{
    using System.ComponentModel.DataAnnotations;

    public class Organizer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string? CompanyName { get; set; }

        public bool IsVerified { get; set; }

        public Organizer Profile Profile { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
