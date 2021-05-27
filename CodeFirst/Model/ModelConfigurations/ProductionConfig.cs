using System.Data.Entity.ModelConfiguration;

namespace CodeFirst.Model.ModelConfigurations
{
    public class ProductionConfig : EntityTypeConfiguration<Production>
    {
        public ProductionConfig()
        {
            this.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
