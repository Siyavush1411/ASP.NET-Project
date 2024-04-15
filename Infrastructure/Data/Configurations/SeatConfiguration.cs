using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models;  

namespace Infrastructure.Data.Configurations  
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Number).IsRequired();
            builder.Property(s => s.IsBusy);
            builder.Property(s => s.CreatedDate);
            builder.Property(s => s.UpdatedDate);
            builder.Property(s => s.LocationId).IsRequired();
        }
    }
}