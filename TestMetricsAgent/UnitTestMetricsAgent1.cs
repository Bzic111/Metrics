using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using MetricsAgent.Controllers;

namespace TestMetricsAgent
{
    public class UnitTestMetricsAgent1
    {
        public class CpuMetricsControllerUnitTests
        {
            private CPUMetricsController controller;
            public CpuMetricsControllerUnitTests()
            {
                controller = new CPUMetricsController();
            }
            [Fact]
            public void GetMetricsFromAgent_ReturnsOk()
            {
                //Arrange
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                //Act
                var result = controller.GetCPUMetrics(fromTime, toTime);
                // Assert
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }
    }
}