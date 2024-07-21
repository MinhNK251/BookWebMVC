using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
	public class EmailSender : IEmailSender
	{
		public string SendGridSecret { get; set; }

		public EmailSender(IConfiguration _config)
		{
			SendGridSecret = _config.GetValue<string>("SendGrid:SecretKey");
		}
		public Task SendEmailAsync(string email, string subject, string htmlMessage)
		{
			var client = new SendGridClient(SendGridSecret);
			//Bhrugen temporary email
			var from = new EmailAddress("hello@dotnetmastery.com", "BookWeb-Echorio");
			var to = new EmailAddress(email);
			var message = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);

			return client.SendEmailAsync(message);
		}
	}
}
