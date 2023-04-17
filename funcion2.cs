using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class funcion2
    {
        private readonly ILogger _logger;

        public funcion2(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<funcion2>();
        }

        [Function("Prueba22")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Hola, desde la segunda funcion");

            return response;
        }
    }
}
