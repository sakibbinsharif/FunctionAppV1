using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;

namespace FunctionAppV2
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            //logger.Fatal($"{System.DateTime.Now} Fatal test");
            log.LogError($"{System.DateTime.Now} Error test");
            log.LogInformation($"{System.DateTime.Now} Info test");
            log.LogDebug($"{System.DateTime.Now} Debug test");
            log.LogTrace($"{System.DateTime.Now} Trace test");

            StandardClassLibrary.StandardClass1 class1 = new StandardClassLibrary.StandardClass1(log);
            class1.Run();

            return (ActionResult)new OkObjectResult($"Hello from v2");
        }
    }
}
