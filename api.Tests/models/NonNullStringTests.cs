using System;
using Xunit;
using TribalThirst.Functions.Models;

namespace api.Tests.models
{
    public class NonNullStringTests
    {
        [Fact]
        public void Constructor_WithNonNullString_SetsValue()
        {
            String value = "hello";
            var nonNullString = new NonNullString(value);
            Assert.Equal(value, nonNullString.Value);
        }

        [Fact]
        public void Constructor_WithEmptyString_AllowsEmpty()
        {
            String value = string.Empty;
            var nonNullString = new NonNullString(value);
            Assert.Equal(value, nonNullString.Value);
        }

        [Fact]
        public void Constructor_WithNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new NonNullString(null));
        }

        [Fact]
        public void Equality_SameValue_AreEqual()
        {
            var a = new NonNullString("abc");
            var b = new NonNullString("abc");
            Assert.Equal(a, b);
        }

        [Fact]
        public void Equality_DifferentValue_AreNotEqual()
        {
            var a = new NonNullString("abc");
            var b = new NonNullString("def");
            Assert.NotEqual(a, b);
        }

        [Fact]
        public void ToString_ReturnsValue()
        {
            var value = "test";
            var nonNullString = new NonNullString(value);
            Assert.Equal(value, nonNullString.ToString());
        }

        [Fact]
        public void ImplicitConversion_ToString_ReturnsValue()
        {
            var value = "implicit";
            NonNullString nonNullString = new NonNullString(value);
            string result = nonNullString;
            Assert.Equal(value, result);
        }
    }
}