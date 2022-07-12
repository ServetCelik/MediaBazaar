using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using MailPriority = System.Net.Mail.MailPriority;
using SmtpClient = System.Net.Mail.SmtpClient;
using MailAddress = System.Net.Mail.MailAddress;

namespace Media_Bazaar
{
    public class EmailSender
    {
        private string from;
        private string password;
        private string host = "smtp.office365.com";
        private int port = 587;

        // send and email to new employees's corporate email address with user name and password.
        public void SendEmailWithNewUserPassword(string Name, string LastName, string NewUserEmail, string NewUserPassword)
        {
            this.from = "mediabazaarhr@outlook.com";
            this.password = "Mediabazaar";


            MailMessage testMessage = new MailMessage();
            MailAddress fromAddress = new MailAddress(this.from);
            SmtpClient objSmtpClient = new SmtpClient(this.host, this.port);
            objSmtpClient.UseDefaultCredentials = false;
            objSmtpClient.Credentials = new NetworkCredential(this.from, this.password);
            objSmtpClient.EnableSsl = true;


            testMessage.From = fromAddress;
            testMessage.To.Add(NewUserEmail);
            testMessage.Subject = "Welcome to Media Bazaar App";
            testMessage.Priority = MailPriority.Normal;
            testMessage.Body = $"Welcome to MediaBazaar App {Name} {LastName}!\n \n your User Name is your MediaBazaar email address:{NewUserEmail} \n and your password is {NewUserPassword}";
            testMessage.IsBodyHtml = false;


            objSmtpClient.Send(testMessage);
        }


        ////Method with test newUser and sender email as  "mediabazaarhr@outlook.com"
        //public void SendEmailWithNewUserPassword(string Name,string LastName,string NewUserEmail, string NewUserPassword)
        //{
        //    this.from = "mediabazaarhr@outlook.com";
        //    this.password = "Mediabazaar";

        //    string testUserEmail = "mediabazaarhr@outlook.com";
        //    MailMessage testMessage = new MailMessage();
        //    MailAddress fromAddress = new MailAddress(this.from);
        //    SmtpClient objSmtpClient = new SmtpClient(this.host, this.port);
        //    objSmtpClient.UseDefaultCredentials = false;
        //    objSmtpClient.Credentials = new NetworkCredential(this.from, this.password);
        //    objSmtpClient.EnableSsl = true;


        //    testMessage.From = fromAddress;
        //    testMessage.To.Add(testUserEmail);
        //    testMessage.Subject = "Welcome to Media Bazaar App";
        //    testMessage.Priority = MailPriority.Normal;
        //    testMessage.Body = $"Welcome to MediaBazaar App {Name} {LastName}!/n /n your User Name is your MediaBazaar EmailAddress:'{NewUserEmail}' /n and your password is '{NewUserPassword}'";
        //    testMessage.IsBodyHtml = false;


        //    objSmtpClient.Send(testMessage);
        //}
    }
}