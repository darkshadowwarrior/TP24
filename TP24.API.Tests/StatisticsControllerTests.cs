using Microsoft.AspNetCore.Mvc;
using Moq;
using TP24.API.Controllers;
using TP24.Data.Entities;
using TP24.Services.Interfaces;

namespace TP24.API.Tests;

public class StatisticsControllerTests : ControllerBase
{
    private Mock<IStatisticsService> _mockStatisticsService;
    private Mock<IPayloadService> _mockPayloadService;
    private StatisticsController _controller;
    
    [SetUp]
    public void Setup()
    {
        _mockStatisticsService = new Mock<IStatisticsService>();
        _mockPayloadService = new Mock<IPayloadService>();
        _controller = new StatisticsController(_mockStatisticsService.Object, _mockPayloadService.Object);
    }

    [Test]
    public void GetStatisticsForOpenAndClosedInvoices()
    {
        _controller.GetStatisticsForOpenAndClosedInvoices();
        _mockStatisticsService.Verify(o => o.GetStatisticsForOpenAndClosedInvoices(It.IsAny<List<Payload>>()), Times.Once);
    }
}