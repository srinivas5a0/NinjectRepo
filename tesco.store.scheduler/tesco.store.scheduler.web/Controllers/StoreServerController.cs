using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tesco.store.scheduler.entities;
using tesco.store.scheduler.entities.StoreServers.ViewModels;
using tesco.store.scheduler.services.StoreServices;

namespace tesco.store.scheduler.web.Controllers
{
    public class StoreServerController : ApiController
    {

        private readonly IStoreServerService storeServerService;

        public StoreServerController(IStoreServerService _storeServerService)
        {
            storeServerService = _storeServerService;
        }

        [HttpGet]
        public HttpResponseMessage GetAllStoreServers()
        {
            try
            {
                var storeServerList = storeServerService.GetAllStores();
                List<StoreServerViewModel> storeServerViewModelList =
                    new List<StoreServerViewModel>();

                foreach (var store in storeServerList)
                {
                    StoreServerViewModel storeModel = new StoreServerViewModel()
                    {
                        id = store.Id,
                        StoreNumber = store.StoreNumber,
                        IpAddress = store.IpAddress
                    };

                    storeServerViewModelList.Add(storeModel);
                }

                return Request.CreateResponse(HttpStatusCode.OK, storeServerViewModelList);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        
    }
}
