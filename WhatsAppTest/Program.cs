using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace WhatsAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Token at twilio.com/console
            const string accountSid = "ACa59e536d3a7129f3d0da33a8fd0eae4d";
            const string authToken = "4a78df272cd6ae44ea4856f74d8ff2a3";

            TwilioClient.Init(accountSid, authToken);
            //0716818319
            var numbers = new List<string>
            {
                "+27716818319",
                "+27837074655"
            };
            Dictionary<string, string> openWith = new Dictionary<string, string>();

            openWith.Add("Adrian", "+27716818319");
            openWith.Add("Xien", "+27837074655");


            foreach (var x in openWith)
            {
                var message = MessageResource.Create(
                body: "This is an iX Test, Have a look at this TEST "+ x.Key,
                from: new PhoneNumber("whatsapp:+14155238886"),
                to: new PhoneNumber("whatsapp:"+x.Value)
            );
                Console.WriteLine(message.Sid);
            }
            



        }
    }
}


