using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using Twilio;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {        
        //Declare Connection

        var count = DBLayer.ValidateLoginCredentials(txtUSERNAME.Text, txtPASSWORD.Text);
        
        if (count > 0)
        {
            Session["Valid"] = "yes";
            Response.Redirect("ContactUs.aspx");
        }
        else
        {
            lblMessage3.Text = "Invalid Credentials.Please Try Again";
            lblMessage3.ForeColor = System.Drawing.Color.Red;
        }
    }
}
//    protected void SendMessage_Click(object sender, EventArgs e)
//    {
//        var accountSid = ConfigurationManager.AppSettings["accountSid"]; // Your Account SID from www.twilio.com/console
//        var authToken = ConfigurationManager.AppSettings["authToken"];  // Your Auth Token from www.twilio.com/console
//        var twilio = new TwilioRestClient(accountSid, authToken);
//        var message = twilio.SendMessage(
//            "+18582603110", // From (Replace with your Twilio number)
//            txtToNumber.Text, // To (Replace with your phone number)
//            "Hello from C#"
//            );
//        if (message.RestException != null)
//        {
//            var error = message.RestException.Message;
//            Console.WriteLine(error);
//            Console.Write("Press any key to continue.");
//            Console.ReadKey();
//        }
//    }
//}