using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using Nexmo.Api;
using RunShawn.Web.Models;

namespace RunShawn.Web.Areas.Customer.Controllers
{
    public class SMSController : Controller
    {
        //private ApplicationDbContext _db;

        //public SMSController(ApplicationDbContext db)
        //{
        //    _db = db;
        //}

        // GET: Customer/SMS
        [System.Web.Mvc.HttpGet]
        public ActionResult Send()
        {
            return RedirectToAction("Rewards", "Dashboard");
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Send(string Text)
        {
            SendMail(Text);

            //var user = _db.Users.FirstOrDefault(u => u.Email == User.Identity.Name);

            return RedirectToAction("Rewards", "Dashboard");
        }

        protected void SendMail(string text)
        {
            MailMessage msg = new MailMessage();
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            try
            {
                msg.Subject = "Potwierdzenie nagrody";
                msg.Body = "Witaj " + User.Identity.Name.Substring(0, User.Identity.Name.IndexOf('@')) + "! Twój przedmiot: " + text + " zostanie dostarczony do pracodawcy już wkrótce.";
                msg.From = new MailAddress("healthback.mail@gmail.com");
                msg.To.Add(User.Identity.Name);
                msg.IsBodyHtml = true;
                client.Host = "smtp.gmail.com";
                System.Net.NetworkCredential basicauthenticationinfo = new System.Net.NetworkCredential("healthback.mail@gmail.com", "zaq1@WSX");
                client.Port = int.Parse("587");
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicauthenticationinfo;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(msg);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}