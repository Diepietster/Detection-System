using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Vehicle_Number_Plate_Detection
{
    internal class Email                                                                                                                   //Create an email class that other classes can inherit to send an email
    {
        public void SendEmailAlert(string body)
        {
            try                                                                                                                            //Use try catch block to catch any errors if errors occur
            {
                NetworkCredential login = new NetworkCredential("detectionalert123@gmail.com", "zcdh yaeu icos zeco");                     //Created new email address and gave this device and app permission to log into account and send email
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = login;
                MailMessage alert = new MailMessage();
                alert.To.Add("pietercoetzee987@gmail.com");
                alert.From = new MailAddress("detectionalert123@gmail.com");
                alert.Subject = "ALERT";
                alert.Body = body;
                client.Send(alert);

            }
            catch (Exception error)
            {
                Console.WriteLine("Can't send email..." + error.Message);                                                                  //Display appropriate message on console if email could not be sent 
            }

        }
    }
}
