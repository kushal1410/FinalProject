using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;
using Twilio;
using System.Configuration;
public partial class ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Valid"] == null)
            Response.Redirect("Login.aspx");
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string message;
        try
        {
            using (MailMessage mm = new MailMessage(ConfigurationManager.AppSettings.Get("EmailId"), txtEmail.Text))
            {
                mm.Subject = txtName.Text;
                mm.Body = txtMessage.Text;
                mm.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = ConfigurationManager.AppSettings.Get("EmailSMTPServer");
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential(ConfigurationManager.AppSettings.Get("EmailId"), ConfigurationManager.AppSettings.Get("EmailPassword"));
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = int.Parse(ConfigurationManager.AppSettings.Get("EmailPort"));
                smtp.Send(mm);
                message = "Email Sent Successfully";
            }
            //Saving Email details
            var status = DBLayer.SaveEmailDetails(txtName.Text, txtEmail.Text, txtMessage.Text);
            if (status)
                message += " and Saved";
            ClientScript.RegisterStartupScript(GetType(), "alert", "alert('" + message + "');", true);
        }
        catch (Exception ex)
        {
            // Log the exception information to 
            // database table or event viewer
            lblMesaage.ForeColor = System.Drawing.Color.Red;
            lblMesaage.Text = ex.Message;
        }
    }
}