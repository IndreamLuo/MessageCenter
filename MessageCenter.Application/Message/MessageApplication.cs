using MessageCenter.Application.Route;
using MessageCenter.Communication;

namespace MessageCenter.Application.Message
{
    public class MessageApplication : IMessageApplication
    {
        IRouteManager RouteManager;

        public MessageApplication(IRouteManager routeManager)
        {
            RouteManager = routeManager;
        }

        public IMessage<dynamic> Send(IMessage<dynamic> messageContent)
        {
            throw new System.NotImplementedException();
        }
    }
}