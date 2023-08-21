using Moq;
using TP24.API.Controllers;
using TP24.Services.Interfaces;
using TP24.Services.Models;

namespace TP24.API.Tests;

public class PayloadControllerTests
{
    private PayloadController _controller;
    private Mock<IPayloadService> _mockService;
    
    [SetUp]
    public void Setup()
    {
        _mockService = new Mock<IPayloadService>();
        _controller = new PayloadController(_mockService.Object);
    }

    [Test]
    public void AddPayload()
    {
        _controller.Add(new PayloadRequest());
        _mockService.Verify(o => o.AddPayload(It.IsAny<PayloadRequest>()), Times.Once);
    }
}