using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tesco.store.scheduler.data.Context;
using tesco.store.scheduler.entities;

namespace tesco.store.scheduler.services.StoreServices
{
    public class StoreServiceImpl : IStoreServerService
    {
        private readonly IRepository<StoreServer> storeServerRepo;

        public StoreServiceImpl(IRepository<StoreServer> _storeServerRepo)
        {
            storeServerRepo = _storeServerRepo;
        }


        public List<entities.StoreServer> GetAllStores()
        {
            return storeServerRepo.Table.Any() ?
                storeServerRepo.Table.OrderBy(i => i.StoreNumber).ToList() :
                Enumerable.Empty<entities.StoreServer>().ToList();
        }

        public IEnumerable<StoreServer> GetAllStoresList()
        {
            return storeServerRepo.Table.
                                   Take(1000).
                                   Skip(1).ToArray();
        }

        public bool AddStore(entities.StoreServer storeServer)
        {
            try
            {
                storeServerRepo.Insert(storeServer);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool DeleteStore(long storeId)
        {
            if (storeServerRepo.Table.Any(i => i.Id.Equals(storeId)))
            {
                storeServerRepo.Delete(storeServerRepo.Table.FirstOrDefault(i => i.Id.Equals(storeId)));
                return true;
            }
            else return false;
        }

        public bool EditStore(entities.StoreServer storeServer)
        {
            if (storeServerRepo.Table.Any(i => i.Id.Equals(storeServer.Id)))
            {
                storeServerRepo.Update(storeServer);
                return true;
            }
            else return false;
        }

        public entities.StoreServer GetStoreByName(string storeName)
        {
            return storeServerRepo.Table.FirstOrDefault(i => i.StoreName.Equals(storeName));
        }

        public List<entities.StoreServer> GetStoresByPage(int pageNumber, int range)
        {
            return storeServerRepo.Table.
                Skip(pageNumber * range).
                Take(range).ToList();
        }
    }
}
