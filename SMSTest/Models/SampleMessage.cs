using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio;

namespace SMSTest.Models
{
    public class SampleMessage
    {
        public string SendSample()
        {
            string AcctSid = "ACb54ced82a92ac0505182ce01b10c6210";
            string AcctToken = "48b80f57b04119bc8bfe92c52ec650a8";
            string phoneFrom = "+12695584756";
            string phoneTo = "+12696016251";

            var TwClient = new TwilioRestClient(AcctSid, AcctToken);
            var message = TwClient.SendMessage(phoneFrom, phoneTo, "This is my message");
            if ((message != null) && (message.RestException != null))
            {
                var error = message.RestException.Message;
                return error;
            }
            
            else return " ";
        }
    }
}