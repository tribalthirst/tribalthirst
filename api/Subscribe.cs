using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace TribalThirst.Functions
{
    public static class Subcription
    {
        [FunctionName("Subscribe")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            if (req.Body == null || string.IsNullOrEmpty(req.ContentType) || !string.Equals(req.ContentType, "application/json", StringComparison.OrdinalIgnoreCase))
            {
                log.LogWarning("Request body is null or content type is not application/json. Exiting function.");
                return new BadRequestObjectResult("Request body cannot be null and must be of type application/json.");
            }
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            if (string.IsNullOrWhiteSpace(requestBody))
            {
                log.LogWarning("Request body is empty. Exiting function.");
                return new BadRequestObjectResult("Request body cannot be empty.");
            }
            

            SubscriberRequest data = JsonConvert.DeserializeObject<SubscriberRequest>(requestBody);


            return new OkObjectResult("Hello World");
        }

        //create a Subcribe Request class that has FirstName, LastName, EmailAddress, SubscriptionDate, SubscriptionName, UnsubscribeDate, ValidationToken
        public class SubscriberRequest
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string EmailAddress { get; set; }
            public string SubscriptionName { get; set; }
        }
    }
}
