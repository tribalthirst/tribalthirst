using System;

using Xunit;

namespace api.tests.integration
{
    public class SubscribeTests
    {
        [Fact]
        [Trait("Category", "Integration")]
        public async Task Subscribe_ReturnsEmptyResponseBody()
        {
            // Arrange
            using var client = new HttpClient();
            var requestUri = "http://localhost:7071/api/Subscribe"; // Adjust the URI as needed

            // Act
            var request = new HttpRequestMessage(HttpMethod.Post, requestUri);
            var response = await client.SendAsync(request);
            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        [Trait("Category", "Integration")]
        public async Task Subscribe_ReturnsOkResult()
        {
            // Arrange
            using var client = new HttpClient();
            var requestUri = "http://localhost:7071/api/Subscribe";
            StringContent content = JsonBodyContent();

            // Act
            var request = new HttpRequestMessage(HttpMethod.Post, requestUri)
            {
                Content = content
            };
            request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await client.SendAsync(request);

            // Assert
            Assert.True(response.IsSuccessStatusCode,
            "Expected success status code, but got: " + response.StatusCode);
        }

        private static StringContent JsonBodyContent()
        {
            var content = new StringContent(
                System.Text.Json.JsonSerializer.Serialize(new
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EmailAddress = "test@example.com",
                    SubscriptionName = "Test Subscription"
                }),
                System.Text.Encoding.UTF8,
                "application/json"
            );
            return content;
        }
    }
}