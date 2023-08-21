using Moq;
using TP24.Data.Entities;
using TP24.Data.Interfaces;
using TP24.Services.Interfaces;
using TP24.Services.Models;
using TP24.Services.Services;

namespace TP24.Data.Tests;

public class Tests
{
    private PayloadService _service;
    private Mock<IPayloadRepository> _mockRepository;
    private Mock<IStatisticsRepository> _mockStatisticsRepository;
    private Mock<IPayloadMapper> _mapper;
    
    
    [SetUp]
    public void Setup()
    {
        _mockRepository = new Mock<IPayloadRepository>();
        _mockStatisticsRepository = new Mock<IStatisticsRepository>();
        _mapper = new Mock<IPayloadMapper>();
        _service = new PayloadService(_mockRepository.Object, _mapper.Object, _mockStatisticsRepository.Object);
    }

    [Test]
    public void AddPayload()
    {
        _mapper.Setup(o => o.MapToEntity(It.IsAny<PayloadRequest>())).Returns(new Payload());
        _mapper.Setup(o => o.MapToResponse(It.IsAny<Payload>())).Returns(new PayloadResponse() { Id = 1 });
        _service.AddPayload(new PayloadRequest());
        _mockRepository.Verify(o => o.AddPayload(It.IsAny<Payload>()));
        _mockStatisticsRepository.Verify(o => o.UpdateTotalOpenInvoicesCount(), Times.Once);
    }
    
    [Test]
    public void UpdatePayload()
    {
        _mapper.Setup(o => o.MapToEntity(It.IsAny<PayloadRequest>())).Returns(new Payload());
        _mapper.Setup(o => o.MapToResponse(It.IsAny<Payload>())).Returns(new PayloadResponse() { Id = 1 });
        _mockRepository.Setup(o => o.GetPayloadById(It.IsAny<int>())).Returns(new Payload() { Id = 1, PaidValue = 200 });
        _service.UpdatePayload(new PayloadRequest() { PaidValue = 34.00 });
        _mockRepository.Verify(o => o.UpdatePayload(It.IsAny<Payload>()));
        _mockStatisticsRepository.Verify(o => o.UpdateTotalOpenInvoicesCount(), Times.Once);
    }
    
    [Test]
    public void GetPayloads()
    {
        _service.GetPayloads();
        _mockRepository.Verify(o => o.GetPayloads());
    }
}