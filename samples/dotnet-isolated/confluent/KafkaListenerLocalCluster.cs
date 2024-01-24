using System;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace Confluent
{
    public class KafkaListenerLocalCluster
    {
        private readonly ILogger _logger;

        public KafkaListenerLocalCluster(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<KafkaListenerLocalCluster>();
        }

       /* [Function("KafkaListenerLocalCluster")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
        [Function("KafkaTrigger")]
        public  void Run(
           [KafkaTrigger("localhost:9092",
                  "docker-connect-status",
                  ConsumerGroup = "$Default")] string eventData, FunctionContext context)
        {
           
            Console.WriteLine("Welcome");
            _logger.LogInformation($"C# Kafka trigger function processed a message: {JObject.Parse(eventData)["Value"]}");
        }*/


        [Function("KafkaTrigger")]
        public void Run(
           [KafkaTrigger("localhost:9092",
                  "docker-connect-status",
                  ConsumerGroup = "$Default")] string eventData, FunctionContext context)
        {

            Console.WriteLine("Welcome");
            _logger.LogInformation($"C# Kafka trigger function processed a message: {JObject.Parse(eventData)["Value"]}");
        }
    }
}
