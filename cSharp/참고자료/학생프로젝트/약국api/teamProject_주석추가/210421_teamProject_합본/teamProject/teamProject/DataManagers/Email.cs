using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace teamProject
{
    class Email
    {
        private MailAddress sendAddress = null;
        private MailAddress toAddress = null;
        private string sendPassword = "이메일비밀번호넣기";

       public Email(string sendMail)
        {
            try
            {
                this.sendAddress = new MailAddress(sendMail);
            }
            catch (Exception)
            {

            }
        }
                
        public void SetToAddress(string toMail)
        {
            // 호출
            this.toAddress = new MailAddress(toMail);
        }

        public string SendEmail(string subject, string body)
        {
            SmtpClient smtp = null;
            MailMessage message = null;
            try
            {
                smtp = new SmtpClient
                {
                
                    Host = "smtp.gmail.com",
                    Port = 587,
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(sendAddress.Address, sendPassword),
                    Timeout = 20000
                };
                message = new MailMessage(sendAddress, toAddress)
                {
                    Subject = subject,
                    SubjectEncoding = Encoding.UTF8,
                    BodyEncoding = Encoding.UTF8,
                    Body = body
                };
                smtp.Send(message);
                return "발주 메일 전송 완료";
            }
            catch (Exception)
            {
                return " 발주 메일 전송 실패";
            }
            finally
            {
                if (smtp != null) { smtp.Dispose(); }
                if (message !=null)
                {
                    message.Dispose();
                }
            }
        }
    }
}
