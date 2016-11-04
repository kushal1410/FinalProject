using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio;

/// <summary>
/// Summary description for twilio
/// </summary>
public class twilio
{
    public static void Main()
    {
        var accountSid = "{{ ACc773101c374fab97babd7009ac99a93f }}"; // Your Account SID from www.twilio.com/console
        var authToken = "{{ 36f3dd3fb756ebdbfa2c0dd8523531d4 }}";  // Your Auth Token from www.twilio.com/console

        var twilio = new TwilioRestClient(accountSid, authToken);
        var message = twilio.SendMessage(
            "+18582603110", // From (Replace with your Twilio number)
            "+4088194648", // To (Replace with your phone number)
            "Hello from C#"
            );

        if (message.RestException != null)
        {
            var error = message.RestException.Message;
            Console.WriteLine(error);
            Console.Write("Press any key to continue.");
            Console.ReadKey();




        }
    }
}
