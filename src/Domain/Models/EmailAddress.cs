using System;

namespace Domain.Models
{
    public class EmailAddress
    {
        public EmailAddress(string value)
        {
            if (!IsValidEmail(value))
            {
                throw new ArgumentException(value, nameof(value));
            }

            Value = value;
        }

        public string Value { get; private set; }

        private bool IsValidEmail(string value)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(value);
                return addr.Address == value;
            }
            catch
            {
                return false;
            }
        }
    }
}