using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CattlewatchAppFinal.Models;
using System.Net.Mail;
using System.Text;


namespace CattlewatchAppFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Collar()
        {
            return View();
        }
        public ActionResult Lora()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    StringBuilder message = new StringBuilder();
                    MailAddress from = new MailAddress(contact.Email.ToString());
                    message.Append("Name: " + contact.FirstName + "\n");
                    message.Append("Last Name: " + contact.LastName + "\n");
                    message.Append("Email: " + contact.Email + "\n");
                    message.Append("Telephone: " + contact.Telephone + "\n\n");
                    message.Append("Subject: " + contact.Supject + "\n\n");
                    message.Append(contact.Message);
                   
                    MailMessage msg = new MailMessage();
                    msg.From = from;
                    msg.To.Add("andilebshange@gmail.com");
                    msg.Subject = "Query on Website";
                    msg.Body = message.ToString();

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("andilebshange@gmail.com", "141296#Maria");
                    smtp.Send(msg);

                    
                    ViewBag.Message = "Thank you for contacting us";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }

            return View("Index");
        }
    }
}