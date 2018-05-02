using MessageCenter.Application.Message;
using MessageCenter.Application.Route;
using StructureMap;

namespace MessageCenter.Application
{
    public class StructureMapRegistry : Registry
    {
        public StructureMapRegistry()
        {
            For<IMessageApplication>().Use<MessageApplication>();
            For<IRouteManager>().Use<RouteManager>();
        }
    }
}