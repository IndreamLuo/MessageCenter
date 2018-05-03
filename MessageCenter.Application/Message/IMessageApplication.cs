using MessageCenter.Communication;

namespace MessageCenter.Application.Message
{
    public interface IMessageApplication
    {
        IMessage<dynamic> Send(IMessage<dynamic> messageContent);
    }
}