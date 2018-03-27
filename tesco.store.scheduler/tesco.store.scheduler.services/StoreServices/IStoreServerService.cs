using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tesco.store.scheduler.entities;

namespace tesco.store.scheduler.services.StoreServices
{
    public interface IStoreServerService
    {
        List<StoreServer> GetAllStores();
        bool AddStore(StoreServer storeServer);
        bool DeleteStore(long storeId);
        bool EditStore(StoreServer storeServer);

        StoreServer GetStoreByName(string storeName);
        List<StoreServer> GetStoresByPage(int pageNumber,int range);
    }
}
