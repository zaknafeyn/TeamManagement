using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using TeamManager.Controllers;

namespace TeamManager
{
    public class ControllersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(typeof (ControllersModule).Assembly);
        }
    }
}