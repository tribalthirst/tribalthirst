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
    public DateTime SubscriptionEnd { get; }

    private Subscription(Builder builder)
    {
        FirstName = builder.FirstName;
        LastName = builder.LastName;
        SubscriptionName = builder.SubscriptionName;
        ValidationToken = builder.ValidationToken;
        SubscriptionStart = builder.SubscriptionStart;
        SubscriptionEnd = builder.SubscriptionEnd;
    }

    public class Builder
    {
        public NonNullString FirstName { get; private set; }
        public NonNullString LastName { get; private set; }
        public EmailAddress EmailAddress { get; private set; }
        public NonNullString SubscriptionName { get; private set; }
        public NonNullString ValidationToken { get; private set; }
        public DateTime SubscriptionStart { get; private set; }
        public DateTime SubscriptionEnd { get; private set; }

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

        public Builder SetSubscriptionEnd(DateTime end)
        {
            SubscriptionEnd = end;
            return this;
        }

        public Subscription Build()
        {
            // Optionally, add validation here
            return new Subscription(this);
        }
    }
}