using System;
using Xunit;
using TribalThirst.Functions.Models;

namespace api.Tests.models
{
    // EmailAddress class to encapsulate email validation logic
    
    public class EmailAddressTests
    {
        [Theory]
        [InlineData("test@example.com", true)]
        [InlineData("user.name+tag+sorting@example.com", true)]
        [InlineData("user@subdomain.example.com", true)]
        [InlineData("invalid-email", false)]
        [InlineData("user@.com", false)]
        [InlineData("user@com", false)]
        [InlineData("", false)]
        public void Email_ReturnsExpectedResult(string email, bool expected)
        {
            bool result = true;
            try
            {
            _ = new EmailAddress(email);
            }
            catch (ArgumentException)
            {
            result = false;
            }
            Assert.Equal(expected, result);
        }
    }
}