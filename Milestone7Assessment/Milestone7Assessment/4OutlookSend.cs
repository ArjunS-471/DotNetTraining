using System;
using System.IO;
using Microsoft.Exchange.WebServices.Data;

namespace Milestone7Assessment
{
    internal class _4OutlookSend
    {
        static void Main4(string[] args)
        {
            string userEmail = "user@yourtenant.com";

            // Set up the EWS service
            var service = new ExchangeService(ExchangeVersion.Exchange2013_SP1)
            {
                Credentials = new WebCredentials("YOUR_EMAIL", "YOUR_PASSWORD"), // Use app password if 2FA is enabled
                Url = new Uri("https://outlook.office365.com/EWS/Exchange.asmx")
            };

            // Create and send the email
            SendEmail(service, userEmail, "Test Email Subject", "This is the body of the email.", @"C:\path\to\report.pdf");
        }

        static void SendEmail(ExchangeService service, string userEmail, string subject, string body, string attachmentPath)
        {
            // Create the email message
            EmailMessage email = new EmailMessage(service)
            {
                Subject = subject,
                Body = new MessageBody(BodyType.Text, body),
            };
            email.ToRecipients.Add(userEmail);

            // Attach the file
            if (File.Exists(attachmentPath))
            {
                email.Attachments.AddFileAttachment(Path.GetFileName(attachmentPath), attachmentPath);
            }
            else
            {
                Console.WriteLine($"Attachment not found: {attachmentPath}");
                return;
            }

            // Send the email
            email.Send();
            Console.WriteLine("Email sent successfully!");
        }
    }
}
