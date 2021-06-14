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
            public CpuMetricsControllerUnitTests() => controller = new CPUMetricsController();
            [Fact]
            public void GetCPUMetrics_ReturnsOk()
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
        public class DotNetMetricsControllerUnitTests
        {
            private DotNetMetricsController controller;
            public DotNetMetricsControllerUnitTests() => controller = new DotNetMetricsController();
            [Fact]
            public void GetDotNetMetrics_ReturnsOk()
            {
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                var result = controller.GetDotNetErrorsCountMetrics(fromTime, toTime);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }
        public class RamMetricsControllerUnitTests
        {
            private RamMetricsController controller;
            public RamMetricsControllerUnitTests() => controller = new RamMetricsController();
            [Fact]
            public void GetDotNetMetrics_ReturnsOk()
            {
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                var result = controller.GetRamMetrics(fromTime, toTime);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }
        public class HddMetricsControllerUnitTests
        {
            private HddMetricsController controller;
            public HddMetricsControllerUnitTests() => controller = new HddMetricsController();
            [Fact]
            public void GetHddMetrics_ReturnsOk()
            {
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                var result = controller.GetHddMetrics(fromTime, toTime);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }
        public class NetworkMetricsControllerUnitTests
        {
            private NetworkMetricsController controller;
            public NetworkMetricsControllerUnitTests() => controller = new NetworkMetricsController();
            [Fact]
            public void GetNetworkMetrics_ReturnsOk()
            {
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                var result = controller.GetNetworkMetrics(fromTime, toTime);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }
    }
}