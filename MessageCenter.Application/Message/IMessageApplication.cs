namespace MessageCenter.Application.Message
{
    public interface IMessageApplication
    {
        dynamic Send(dynamic messageContent);
    }
}