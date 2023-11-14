using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace graphQlApi_tutoriel_CRUD.Entities.Context.Configuration
{
    public class OwnerConfiguration :IEntityTypeConfiguration<Owner>
    {
        private Guid[] _ids;
        public OwnerConfiguration(Guid[] id) {
            _ids = id;
        }

        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasData(
                        new Owner { Id= _ids[0],Name="john Doe",Address="Jhon street" },
                        new Owner { Id = _ids[1], Name = "Jane Doe", Address = "Jane street" }
                );
        }
    }
}
