using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tesco.store.scheduler.entities;

namespace tesco.store.scheduler.data.Mappings
{
    public class StoreServerMap : EntityTypeConfiguration<StoreServer>
    {
        public StoreServerMap()
        {
            //key
            this.HasKey(i => i.Id);
            //properties
            this.Property(i => i.StoreNumber).IsRequired();
            this.Property(i => i.StoreName).IsRequired();
            this.Property(i => i.IpAddress).IsRequired();

            //table name
            this.ToTable("tblStoreServers");

        }
    }
}
