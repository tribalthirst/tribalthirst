using System;

using TribalThirst.Functions.Models;


public class Subscription
{
    public NonNullString FirstName { get; }
    public NonNullString LastName { get; }
    public NonNullString SubscriptionName { get; }
    public NonNullString ValidationToken { get; }
    public EmailAddress EmailAddress { get; }
    public DateTime SubscriptionStart { get; }

    private Subscription(Builder builder)
    {
        FirstName = builder.FirstName ?? new NonNullString(string.Empty);
        LastName = builder.LastName ?? new NonNullString(string.Empty);
        ;
        EmailAddress = builder.EmailAddress ?? throw new ArgumentNullException(nameof(builder.EmailAddress), "Email address cannot be null.");
        SubscriptionName = builder.SubscriptionName ?? throw new ArgumentNullException(nameof(builder.SubscriptionName), "Subscription name cannot be null.");
        ValidationToken = builder.ValidationToken ?? new NonNullString(Guid.NewGuid().ToString());
        SubscriptionStart = builder.SubscriptionStart == default ? DateTime.UtcNow : builder.SubscriptionStart;
    }

    public class Builder
    {
        public NonNullString FirstName { get; private set; }
        public NonNullString LastName { get; private set; }
        public EmailAddress EmailAddress { get; private set; }
        public NonNullString SubscriptionName { get; private set; }
        public NonNullString ValidationToken { get; private set; }
        public DateTime SubscriptionStart { get; private set; }

        public Builder SetFirstName(string firstName)
        {
            FirstName = new NonNullString(firstName);
            return this;
        }

        public Builder SetLastName(string lastName)
        {
            LastName = new NonNullString(lastName);
            return this;
        }
        public Builder SetEmailAddress(string email)
        {
            EmailAddress = new EmailAddress(email);
            return this;
        }

        public Builder SetSubscriptionName(string subscriptionName)
        {
            SubscriptionName = new NonNullString(subscriptionName);
            return this;
        }

        public Builder SetValidationToken(string validationToken)
        {
            ValidationToken = new NonNullString(validationToken);
            return this;
        }

        public Builder SetSubscriptionStart(DateTime start)
        {
            SubscriptionStart = start;
            return this;
        }


        public Subscription Build()
        {
            return new Subscription(this);
        }
    }
}