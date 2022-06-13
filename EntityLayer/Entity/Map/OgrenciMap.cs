using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity.Map
{
    public class OgrenciMap: EntityTypeConfiguration<Ogrenci>
    {
        public OgrenciMap()
        {
            this.ToTable("hede");
            this.HasKey(p => p.OgrenciId);
            this.Property(p=>p.OgrenciAdi)
                .IsRequired()
                .HasColumnName("ad")
                .HasColumnType("varchar")
                .HasMaxLength(50);
        }
        
    }
}
