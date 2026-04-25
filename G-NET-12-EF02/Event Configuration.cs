using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF02
{


    public class EventConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasOne(e => e.ParentEvent)
                .WithMany(e => e.Sessions)
                .HasForeignKey(e => e.ParentEventId);

            // Shadow Properties
            builder.Property<DateTime>("CreatedAt")
                .HasDefaultValueSql("GETDATE()");

            builder.Property<DateTime>("UpdatedAt")
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
