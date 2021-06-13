using System;
using Xunit;
using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestMetricsManager
{
    public class UnitTest1
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
                var agentId = 1;
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                //Act
                var result = controller.GetMetricsFromAgent(agentId, fromTime, toTime);
                // Assert
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }

        }
    }
}