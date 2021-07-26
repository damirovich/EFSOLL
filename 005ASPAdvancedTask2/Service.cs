using MailKit.Security;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace _005ASPAdvancedTask2
{
    public class Service
    {
        private readonly ILogger<Service> logger;
        public Service(ILogger<Service> logger) {
            this.logger = logger;
        }
       
        public void SendEmilCustom() {
            try
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("Моя компания", "admin@mycompany.com")); //отправитель сообщения
                message.To.Add(new MailboxAddress("baktilekashyrov8@gmail.com")); //адресат сообщения
                message.Subject = "Сообщение от MailKit"; //тема сообщения
                message.Body = new BodyBuilder() { HtmlBody = "<div style=\"color: green;\">Сообщение от MailKit</div>" }.ToMessageBody(); //тело сообщения (так же в формате HTML)

                using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    //client.Connect("smtp.gmail.com", 587, true); //либо использум порт 465
                    client.Authenticate("baktilekashyrov8@gmail.com", "sectret"); //логин-пароль от аккаунта
                    client.Send(message);

                    client.Disconnect(true);
                    logger.LogInformation("Сообщение отправлено успешно!");
                }
            }
            catch (Exception e)
            {

                logger.LogError(e.GetBaseException().Message);
            }
        }
    }
}
