using Microsoft.Extensions.Logging;
using System;

namespace StandardClassLibrary
{
    public class StandardClass1
    {
        private ILogger _logger;
        public StandardClass1(ILogger logger)
        {
            this._logger = logger;
        }
        public void Run()
        {
            _logger.LogInformation("ClassLib Info Collected");
            _logger.LogWarning("ClassLib warning Collected");
            _logger.LogDebug("ClassLib Debug Collected");
            _logger.LogTrace("ClassLib Trace Collected");
            _logger.LogError(new ApplicationException("ClassLib My exception"), "Error Collected with exception in ClassLib ");
            _logger.LogCritical(new ApplicationException("ClassLib My Critical exception"), "My Error Collected with exception in ClassLib ");
        }
    }
}
