using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using PizzaPan.EntityLayer.Concrete;
using PizzaPan.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel p)
        {
      
            Random r = new Random();
            int x = r.Next(100000, 1000000);

            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Mail,
                UserName = p.UserName,
                ConfirmCode = x
            };
            if (p.Password==p.ConfirmPassword )
            {

                var result= await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {

                    MimeMessage mimeMessage = new MimeMessage();
                    MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "projekursapi@gmail.com");
                    mimeMessage.From.Add(mailboxAddressFrom);

                    MailboxAddress mailboxAddressTo = new MailboxAddress("User", p.Mail);
                    mimeMessage.To.Add(mailboxAddressTo);

                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = "Giriş yapabilmek için onaylama kodunuz:" + x;
                    mimeMessage.Body = bodyBuilder.ToMessageBody();

                    mimeMessage.Subject = "Doğruma Kodu";

                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Connect("smtp.gmail.com", 587, false);
                    smtpClient.Authenticate("projekursapi@gmail.com", "luenooycyyxsnbab");
                    smtpClient.Send(mimeMessage);
                    smtpClient.Disconnect(true);
                    TempData["UserName"] = appUser.UserName;
                    return RedirectToAction("Index","ConfirmEmail");
                }
                else
                {
                    foreach (var i in result.Errors)
                    {
                        ModelState.AddModelError("", i.Description);
                    }
                }

            }
            else
            {
                ModelState.AddModelError("", "Şifreler Eşleşmiyor");
            }

            return View();

        }
    
        [HttpGet]
        public IActionResult ConfirmMailCode()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConfirmMailCode(RegisterViewModel p)
        {
            return View();
        }

    }
}
