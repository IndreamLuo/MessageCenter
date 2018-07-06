using MessageCenter.DataAccess.Entities;

namespace MessageCenter.Application.Route
{
    public interface IRouteManager
    {
        EndPoint this[int key] { get; }
    }
}