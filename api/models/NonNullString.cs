using System;

namespace TribalThirst.Functions.Models
{
    /// <summary>
    /// Represents a string that cannot be null (but can be empty).
    /// </summary>
    public sealed class NonNullString : ValueObject
    {
        public string Value { get; }

        public NonNullString(string value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value), "String value cannot be null.");
            Value = value;
        }

        protected override System.Collections.Generic.IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value;

        public static implicit operator string(NonNullString nonNullString) => nonNullString.Value;
    }
}