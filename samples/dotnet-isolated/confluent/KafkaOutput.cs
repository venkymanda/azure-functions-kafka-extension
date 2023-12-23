using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.Functions.Worker.Http;
using System.Net;

namespace Confluent
{
    public class KafkaOutput
    {
        
        private readonly ILogger _logger;

        public KafkaOutput(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<KafkaOutput>();
        }
        [Function("KafkaOutput")]
        
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
             _logger.LogInformation("C# HTTP trigger function processed a request.2");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }

    
        
    
}
