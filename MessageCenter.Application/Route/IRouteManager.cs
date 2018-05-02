using MessageCenter.DataAccess.Entities;

namespace MessageCenter.Application.Route
{
    public interface IRouteManager
    {
        Api this[string key] { get; }
    }
}