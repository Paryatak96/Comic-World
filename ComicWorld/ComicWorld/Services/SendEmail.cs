using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SendGrid.Helpers.Mail;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ComicWorld.Services
{
    public class SendEmail 
    {
        public static async Task Send(string bodyMessage, string userEmailAddress)
        {
            var apikey = "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";
            var client = new SendGridClient(apikey);
            var from = new EmailAddress("comicworld@onet.pl", "ComicWorld Teams");
            var subject = "Link to activated accound in comicworld.pl";
            var to = new EmailAddress(userEmailAddress, userEmailAddress);
            var plainTextContent = $"Please confirm your account by<a href= '{HtmlEncoder.Default.Encode(bodyMessage)}' > clicking here</ a >.";
            var htmlContent = $"Please confirm your account by<a href= '{HtmlEncoder.Default.Encode(bodyMessage)}' > clicking here</ a >.";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }

        //private readonly ILogger _logger;

        //public SendEmail(IOptions<AuthMessageSenderOptions> optionsAccessor,
        //                   ILogger<SendEmail> logger)
        //{
        //    Options = optionsAccessor.Value;
        //    _logger = logger;
        //}

        //public AuthMessageSenderOptions Options { get; } //Set with Secret Manager.

        //public async Task SendEmailAsync(string toEmail, string subject, string message)
        //{
        //    if (string.IsNullOrEmpty(Options.SendGridKey))
        //    {
        //        throw new Exception("Null SendGridKey");
        //    }
        //    await Execute(Options.SendGridKey, subject, message, toEmail);
        //}

        //public async Task Execute(string apiKey, string subject, string message, string toEmail)
        //{
        //    var client = new SendGridClient(apiKey);
        //    var msg = new SendGridMessage()
        //    {
        //        From = new EmailAddress("comicworld@onet.pl", "Confirm Your E-mail"),
        //        Subject = subject,
        //        PlainTextContent = message,
        //        HtmlContent = message
        //    };
        //    msg.AddTo(new EmailAddress(toEmail));

        //    // Disable click tracking.
        //    // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
        //    msg.SetClickTracking(false, false);
        //    var response = await client.SendEmailAsync(msg);
        //    _logger.LogInformation(response.IsSuccessStatusCode
        //                           ? $"Email to {toEmail} queued successfully!"
        //                           : $"Failure Email to {toEmail}");
        //}

    }
}
