using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Conan.Model;

namespace Conan.DAL
{

    public class SkuAreaMapping : EntityTypeConfiguration<SkuArea>
    {
        public SkuAreaMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Id)
                .IsRequired();
         
            ToTable("SkuArea");
        }
    }
}
