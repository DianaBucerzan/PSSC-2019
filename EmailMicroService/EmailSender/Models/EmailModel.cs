using SendGrid.Helpers.Mail;

namespace EmailSender.Models
{
    public class EmailModel
    {
        public EmailAddress From { get; set; }
        public string Subject { get; set; }
        public EmailAddress To { get; set; }
        public string HtmlContent { get; set; }

        public EmailModel(EmailAddress from, string subject, EmailAddress to, string htmlContent)
        {
            From = from;
            Subject = subject;
            To = to;
            HtmlContent = htmlContent;
        }
        
        public EmailModel(string from, string subject, string to, string htmlContent)
        {
            From = new EmailAddress
            {
                Email = from
            };
            Subject = subject;
            To = new EmailAddress
            {
                Email = to
            };
            HtmlContent = htmlContent;
        }

        public EmailModel()
        {
        }
    }
}