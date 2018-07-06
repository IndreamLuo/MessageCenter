using System.Linq;
using MessageCenter.DataAccess;
using MessageCenter.DataAccess.Entities;

namespace MessageCenter.Application.Route
{
    public class RouteManager : IRouteManager
    {
        readonly MessageCenterDbContext DbContext;

        public RouteManager(MessageCenterDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public EndPoint this[int key] => DbContext.EndPoints.FirstOrDefault(endPoint => endPoint.Key == key);
    }
}