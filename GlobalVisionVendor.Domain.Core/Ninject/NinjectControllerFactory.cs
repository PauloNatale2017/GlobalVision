using System;
using Ninject;
using System.Web.Mvc;
using System.Web.Routing;
using System.ServiceModel.Channels;

namespace GlobalVisionVendor.Domain.Core.Ninject
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {

        private IKernel ninjectKernnel;


        public NinjectControllerFactory()
        {
            ninjectKernnel = new StandardKernel();
            AdBinding();
        }

        //protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        //{
        //    return controllerType == null ? null : (IController)ninjectKernnel.Get(controllerType);
        //}


        private void AdBinding()
        {
            ninjectKernnel.Bind<GlobalVisionVendor.Domain.Core.IRepositorio.IRepository<GlobalVisionVendor.Domain.MapEntities.Entities.CadastroEndereco>>().To<GlobalVisionVendor.Domain.Core.Repository.CadastroEnderecoRepository>();
            ninjectKernnel.Bind<GlobalVisionVendor.Domain.Core.IRepositorio.IRepository<GlobalVisionVendor.Domain.MapEntities.Entities.CadastroLatLng>>().To<GlobalVisionVendor.Domain.Core.Repository.CadastroLatLngRepository>();
        }



    }
}
