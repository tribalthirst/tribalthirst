using System.IO;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Linq;

namespace TribalThirst.Functions
{
    public class Subscribe
    {
        private readonly ILogger _logger;

        public Subscribe(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Subscribe>();
        }

        [Function("Subscribe")]
        public async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous,"get","post")]
            HttpRequestData req,
             FunctionContext executionContext)
        {
            // In isolated mode, use TryGetValues to access headers
            if (!req.Headers.TryGetValues("content-type", out var contentType) ||
                req.Body == null ||
                !contentType.Any(ct => ct.Contains("application/json")))
            {
                _logger.LogWarning("Request body is null or content type is not application/json. Exiting function.");
                var badResponse = req.CreateResponse(HttpStatusCode.BadRequest);
                await badResponse.WriteStringAsync("Request body cannot be null and must be of type application/json.");
                return badResponse;
            }

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            if (string.IsNullOrWhiteSpace(requestBody))
            {
                _logger.LogWarning("Request body is empty. Exiting function.");
                var badResponse = req.CreateResponse(HttpStatusCode.BadRequest);
                await badResponse.WriteStringAsync("Request body cannot be empty.");
                return badResponse;
            }

            SubscriberRequest data = JsonSerializer.Deserialize<SubscriberRequest>(requestBody);

            var response = req.CreateResponse(HttpStatusCode.OK);
            await response.WriteStringAsync("Hello World");
            return response;
        }

        public class SubscriberRequest
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string EmailAddress { get; set; }
            public string SubscriptionName { get; set; }
        }
    }
}
