using System.Collections.Generic;

namespace MessageCenter.Communication
{
    public interface IMessage
    {
        int Id { get; set; }
        int Key { get; set; }
        List<int> RouteServerIds { get; set; }
    }

    public interface IMessage<TMessageContent> : IMessage
    {
        TMessageContent Content { get; set; }
    }
}