using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManager.Controllers
{
    [Route("api/metrics/cpu")]
    [ApiController]
    public class CPUMetricsController : ControllerBase
    {
        private readonly ILogger<CPUMetricsController> _logger;
        public CPUMetricsController(ILogger<CPUMetricsController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog in CpuMetricsController");
        }
        public CPUMetricsController()
        {
            _logger.LogDebug(1, "NLog in CpuMetricsController");
        }

        [HttpGet("agent/{agentId}/from/{fromTime}/to/{toTime}")]
        public IActionResult GetCPUMetricsFromAgent([FromRoute] int agentId, [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            _logger.LogInformation($"{DateTime.Now} : GetCPUMetricsFromAgent.\nAgent Id: {agentId}\nFrom time: {fromTime}\nTo time: {toTime}\n");
            return Ok();
        }
        [HttpGet("cluster/from/{fromTime}/to/{toTime}")]
        public IActionResult GetCPUMetricsFromAllCluster([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            _logger.LogInformation($"{DateTime.Now} : GetCPUMetricsFromAllCluster.\nFrom time: {fromTime}\nTo time: {toTime}\n");
            return Ok();
        }
    }
}
