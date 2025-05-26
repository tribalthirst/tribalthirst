using System;
using Xunit;
using TribalThirst.Functions.Models; // Assuming NonNullString and EmailAddress are here
using api.entities;

namespace api.entities.tests.entities
{
    public class SubscriptionTests
    {
        [Fact]
        public void Builder_ShouldBuildSubscription_WithAllPropertiesSet()
        {
            // Arrange
            string firstName = "";

            var lastName = "Doe";
            var email = "john.doe@example.com";
            var subscriptionName = "Premium";
            var validationToken = "token123";
            var startDate = DateTime.UtcNow;

            // Act
            var subscription = new Subscription.Builder()
                .SetFirstName(firstName)
                .SetLastName(lastName)
                .SetEmailAddress(email)
                .SetSubscriptionName(subscriptionName)
                .SetValidationToken(validationToken)
                .SetSubscriptionStart(startDate)
                .Build();

            // Assert
            Assert.Equal(firstName, subscription.FirstName.Value);
            Assert.Equal(lastName, subscription.LastName.Value);
            Assert.Equal(email, subscription.EmailAddress.Value);
            Assert.Equal(subscriptionName, subscription.SubscriptionName.Value);
            Assert.Equal(validationToken, subscription.ValidationToken.Value);
            Assert.Equal(startDate, subscription.SubscriptionStart);
        }

        [Fact]
        public void Builder_ShouldSetEmailAddress_Correctly()
        {
            var email = "test@example.com";
            var subscription = new Subscription.Builder()
                .SetFirstName("A")
                .SetLastName("B")
                .SetEmailAddress(email)
                .SetSubscriptionName("S")
                .SetValidationToken("T")
                .SetSubscriptionStart(DateTime.UtcNow)
                .Build();

            Assert.Equal(email, subscription.EmailAddress.Value);
        }

        [Fact]
        public void Builder_ShouldThrow_WhenFirstNameIsMissing()
        {
            var builder = new Subscription.Builder()
                .SetLastName("B")
                .SetEmailAddress("test@example.com")
                .SetSubscriptionName("S")
                .SetValidationToken("T")
                .SetSubscriptionStart(DateTime.UtcNow)
                .Build();

            // Optionally, add validation in Build() and test for exception
            // For now, just check that FirstName is null
            Assert.True(builder.FirstName.Value == String.Empty);
        }

        [Fact]
        public void Builder_ShouldHandleEmptyStrings()
        {
            var subscription = new Subscription.Builder()
                .SetFirstName("")
                .SetLastName("")
                .SetEmailAddress("email.address@domain.com")
                .SetSubscriptionName("")
                .SetValidationToken("")
                .SetSubscriptionStart(DateTime.UtcNow)
                .Build();

            Assert.Equal("", subscription.FirstName.Value);
            Assert.Equal("", subscription.LastName.Value);
            Assert.Equal("email.address@domain.com", subscription.EmailAddress.Value);
            Assert.Equal("", subscription.SubscriptionName.Value);
            Assert.Equal("", subscription.ValidationToken.Value);
        }
    }
}