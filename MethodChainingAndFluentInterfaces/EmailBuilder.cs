namespace MethodChainingAndFluentInterfaces
{
    public class EmailBuilder
    {
        private string _sender;
        private string _recipient;
        private string _subject;
        private string _body;

        public EmailBuilder SetSender(string senderEmail)
        {
            _sender = senderEmail;
            return this;
        }

        public EmailBuilder SetRecipient(string recipientEmail)
        {
            _recipient = recipientEmail;
            return this;
        }

        public EmailBuilder SetSubject(string emailSubject)
        {
            _subject = emailSubject;
            return this;
        }

        public EmailBuilder SetBody(string emailBody)
        {
            _body = emailBody;
            return this;
        }

        public void Send()
        {
            // Code to send the email
            Console.WriteLine($"Sending email from {_sender} to {_recipient}");
            Console.WriteLine($"Subject: {_subject}");
            Console.WriteLine($"Body: {_body}");
            Console.WriteLine("Email sent!");
        }
    }

}
