using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionAppV1
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, ILogger log)
        {
            //logger.Fatal($"{System.DateTime.Now} Fatal test");
            log.LogError($"{System.DateTime.Now} Error test");
            log.LogInformation($"{System.DateTime.Now} Info test");
            log.LogDebug($"{System.DateTime.Now} Debug test");
            log.LogTrace($"{System.DateTime.Now} Trace test");


            var obj = new FrameworkClassLibrary.FrameworkClass1(log);
            return req.CreateResponse(HttpStatusCode.OK, "Hello ");
        }
    }
}
