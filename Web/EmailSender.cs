using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Web
{
    public class EmailSender
    {
        /// <summary>
        /// Send mail async.
        /// <see cref="https://myaccount.google.com/lesssecureapps">lesssecureapps</see> 
        /// </summary>
        /// <param name="toEmail">to email</param>
        /// <param name="content">content html to send</param>
        /// <param name="subject">subject mail</param>
        /// config AppSettings["fromEmail"] and AppSettings["passwordEmail"].
        /// <returns></returns>
        public static async Task<KeyValuePair<bool, string>> SendGMail(string toEmail, object content, string subject = "THÔNG BÁO", bool IsBodyHtml = true)
        {
            try
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    string fromEmail = ConfigurationManager.AppSettings["fromEmail"];
                    string passwordEmail = ConfigurationManager.AppSettings["passwordEmail"];

                    var smtp = new SmtpClient("smtp.gmail.com", 587)
                    {
                        EnableSsl = true,
                        UseDefaultCredentials = false,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        Credentials = new NetworkCredential(fromEmail, passwordEmail),
                    };
                    await smtp.SendMailAsync(new MailMessage(fromEmail, toEmail, subject, content + "") { IsBodyHtml = IsBodyHtml });
                    return new KeyValuePair<bool, string>(true, "OK");
                }
                return new KeyValuePair<bool, string>(false, "Network is not Valable");
            }
            catch (Exception ex)
            {
                return new KeyValuePair<bool, string>(false, $"Thất bại. {ex.Message}");
            }
        }
    }
}
