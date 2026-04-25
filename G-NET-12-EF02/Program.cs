using System.Net;

namespace G_NET_12_EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using var context = new AppDbContext();

            // 🟢 تأكد إن الداتابيز اتعملت
            context.Database.EnsureCreated();


            // 🟢 Create Organizer
            var organizer = new Organizer
            {
                Name = "Tech Corp",
                CompanyName = "Tech Corp Ltd",
                IsVerified = true,
                Profile = new OrganizerProfile
                {
                    Bio = "We organize tech events",
                    Website = "www.techcorp.com",
                    Logo = "logo.png"
                }
            };


            // 🟢 Create Event
            var event1 = new Event
            {
                Title = "Tech Conference",
                Description = "Big event",
                StartDate = DateTime.Now,
                MaxAttendees = 100,
                Organizer = organizer
            };


            // 🟢 Session (Self Relationship 🔥)
            var session = new Event
            {
                Title = "AI Workshop",
                Description = "AI session",
                StartDate = DateTime.Now,
                MaxAttendees = 30,
                ParentEvent = event1
            };


            // 🟢 Create Attendee
            var attendee = new Attendee
            {
                FullName = "Ahmed Ali",
                Email = "ahmed@test.com",
                Address = new Address
                {
                    Street = "Street 1",
                    City = "Cairo",
                    Country = "Egypt",
                    PostalCode = "12345"
                },
                Badge = new Badge
                {
                    BadgeNumber = "B001",
                    IssueDate = DateTime.Now,
                    Tier = BadgeTier.VIP
                }
            };


            // 🟢 Registration (Many-to-Many)
            var registration = new Registration
            {
                Attendee = attendee,
                Event = event1,
                Note = "Looking forward"
            };


            // 🟢 Save Data
            context.AddRange(organizer, event1, session, attendee, registration);
            context.SaveChanges();


            // 🟢 Read Data
            var events = context.Events.ToList();

            foreach (var ev in events)
            {
                Console.WriteLine($"Event: {ev.Title}");
            }





        }
    }
}
