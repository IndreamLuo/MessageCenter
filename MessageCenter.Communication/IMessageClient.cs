namespace MessageCenter.Communication
{
    public interface IMessageClient
    {
        IMessage Send(IMessage message);
    }
}