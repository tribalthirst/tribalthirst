using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace TribalThirst.Functions.Models
{
    public sealed class EmailAddress : ValueObject
    {
        public string Value { get; }

        public EmailAddress(string value)
        {
 
            if (string.IsNullOrWhiteSpace(value) || !IsValidEmail(value))
            {
                throw new ArgumentException("Invalid email address.", nameof(value));
            }
            Value = value;
        }

        private bool IsValidEmail(string email)
        {
        
        try
        {
            var addr = new MailAddress(email);
            var hostParts = addr.Host.Split('.');
            return hostParts.Length > 1;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Email validation failed: {e.Message}");
            return false;
        }

        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value.ToLowerInvariant();
        }

        public override string ToString() => Value;
    }
}