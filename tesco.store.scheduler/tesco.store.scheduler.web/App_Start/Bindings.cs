using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tesco.store.scheduler.services.StoreServices;

namespace tesco.store.scheduler.web.App_Start
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IStoreServerService>().To<StoreServiceImpl>();
        }
    }
}