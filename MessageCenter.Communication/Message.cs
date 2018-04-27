using System.Collections.Generic;

namespace MessageCenter.Communication
{
    public abstract class Message : IMessage
    {
        public int Id { get; set; }
        public int Key { get; set; }
        public List<int> RouteServerIds { get; set; }
    }

    public class Message<TMessageContent> : Message, IMessage<TMessageContent>
    {
        public Message(TMessageContent content)
        {
            Content = content;
        }

        public TMessageContent Content { get; set; }
    }
}