using System.Data.Entity;
using Autofac;

namespace TeamManager.DataAccess
{
    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            TeamManagerContext.Configure();

            builder.Register(x => new TeamManagerContext()).SingleInstance().As<TeamManagerContext>();
        }
    }
}