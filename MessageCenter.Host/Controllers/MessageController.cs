using MessageCenter.Application.Message;
using MessageCenter.Communication;
using Microsoft.AspNetCore.Mvc;

namespace MessageCenter.Host.Controllers
{
    [Route("[Controller]")]
    public class MessageController : Controller
    {
        readonly IMessageApplication MessageApplication;

        protected MessageController(IMessageApplication messageApplication)
        {
            MessageApplication = messageApplication;
        }

        [HttpPost]
        public dynamic Send(dynamic messageContent)
        {
            return MessageApplication.Send(messageContent);
        }
    }
}