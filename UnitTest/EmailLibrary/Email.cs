using System.Net;
using System.Net.Mail;
using System;

namespace EmailLibrary
{
    public class Email : IEmail
    {
        public string client { get; set; }
        public string email { get; set; }

        public string recipient { get; set; }

        public string subject { get; set; }

        public string body { get; set; }
        public bool SendEmail()
        {
            bool success = false;
            //HUGE LOGIC ...

            try
            {
                //
                var smtpClient = new SmtpClient(client)
                {
                    Port = 587,
                    Credentials = new NetworkCredential("email", "password"),
                    EnableSsl = true,
                };
                //HUGE LOGIC ...

                //

                smtpClient.Send(email, recipient, subject, body);
            }
            catch (Exception)
            {
                success = false;
            }
            success = true;

            return success;
        }
    }
}
