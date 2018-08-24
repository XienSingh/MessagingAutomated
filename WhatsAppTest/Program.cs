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
            const string accountSid = "##";//Provider Provided
            const string authToken = "##";//Provider Provided

            TwilioClient.Init(accountSid, authToken);

            //OverKill for now until a DB is created, and a premium  Acc
            Dictionary<string, string> Contacts = new Dictionary<string, string>();

            Contacts.Add("Person1", "+#####");
            Contacts.Add("Person2", "+#####");


            foreach (var x in Contacts)
            {
                var message = MessageResource.Create(
                body: "This is a Test, Have a look at this TEST : "+ x.Key,
                from: new PhoneNumber("whatsapp:+###"), //Provider ID
                to: new PhoneNumber("whatsapp:"+x.Value)
            );
                Console.WriteLine(message.Sid);
            }
            



        }
    }
}


