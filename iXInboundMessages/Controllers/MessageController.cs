using System.Web.Mvc;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;

namespace iXInboundMessages.Controllers
{
    public class MessageController : TwilioController
    {
        [HttpPost]
        public TwiMLResult Index()
        {
            var messagingResponse = new MessagingResponse();
            messagingResponse.Message("This is a Test Reciever message");

            return TwiML(messagingResponse);
        }
    }
}