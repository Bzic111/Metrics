using System;
using Xunit;
using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace TestMetricsManager
{
    public class UnitTestMetricsManager1
    {
        public class CpuMetricsControllerUnitTests
        {
            private CPUMetricsController controller;
            public CpuMetricsControllerUnitTests() => controller = new CPUMetricsController();
            [Fact]
            public void GetCPUMetricsFromAgent_ReturnsOk()
            {
                //Arrange
                var agentId = 1;
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                //Act
                var result = controller.GetCPUMetricsFromAgent(agentId, fromTime, toTime);
                // Assert
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
            [Fact]
            public void GetCPUMetricsFromAllCluster_ReturnsOk()
            {
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                var result = controller.GetCPUMetricsFromAllCluster(fromTime, toTime);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }

        }
        public class AgentsControllerUnitTests
        {
            private AgentsController controller;
            private AgentInfo agent;
            public AgentsControllerUnitTests()
            {
                controller = new AgentsController();
                agent = new AgentInfo(1, null);
            }
            [Fact]
            public void RegisterAgent_ReturnsOk()
            {
                var result = controller.RegisterAgent(agent);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
            [Fact]
            public void EnableAgentById_ReturnsOk()
            {
                var result = controller.EnableAgentById(agent.AgentId);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
            [Fact]
            public void DisableAgentById_ReturnsOk()
            {
                var result = controller.DisableAgentById(agent.AgentId);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }
        public class DotNetControllerUnitTests
        {
            private DotNetMetricsController controller;
            public DotNetControllerUnitTests() => controller = new DotNetMetricsController();
            [Fact]
            public void GetDotNetMetricsFromAgent_ReturnsOk()
            {
                var agentId = 1;
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                var result = controller.GetDotNetMetricsFromAgent(agentId,fromTime, toTime);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
            [Fact]
            public void GetDotNetMetricsFromAllCluster_ReturnsOk()
            {
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                var result = controller.GetDotNetMetricsFromAllCluster(fromTime, toTime);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }
        public class RamControllerUnitTests
        {
            RamMetricsController controller;
            public RamControllerUnitTests() => controller = new RamMetricsController();
            [Fact]
            public void GetRamMetricsFromAgent_ReturnsOk()
            {
                var agentId = 1;
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                var result = controller.GetRamMetricsFromAgent(agentId, fromTime, toTime);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
            [Fact]
            public void GetRamMetricsFromAllCluster_ReturnsOk()
            {
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                var result = controller.GetRamMetricsFromAllCluster(fromTime, toTime);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }
        public class HddControllerUnitTests
        {
            HddMetricsController controller;
            public HddControllerUnitTests() => controller = new HddMetricsController();
            [Fact]
            public void GetHddMetricsFromAgent_ReturnsOk()
            {
                var agentId = 1;
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                var result = controller.GetHddMetricsFromAgent(agentId, fromTime, toTime);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
            [Fact]
            public void GetHddMetricsFromAllCluster_ReturnsOk()
            {
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                var result = controller.GetHddMetricsFromAllCluster(fromTime, toTime);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }
        public class NetWorkControllerUnitTests
        {
            NetworkMetricsController controller;
            public NetWorkControllerUnitTests() => controller = new NetworkMetricsController();
            [Fact]
            public void GetNetworkMetricsFromAgent_ReturnsOk()
            {
                var agentId = 1;
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                var result = controller.GetNetworkMetricsFromAgent(agentId, fromTime, toTime);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
            [Fact]
            public void GetNetworkMetricsFromAllCluster_ReturnsOk()
            {
                var fromTime = TimeSpan.FromSeconds(0);
                var toTime = TimeSpan.FromSeconds(100);
                var result = controller.GetNetworkMetricsFromAllCluster(fromTime, toTime);
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }
    }
}