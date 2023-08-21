using Moq;
using TP24.Data.Entities;
using TP24.Data.Repositories;
using TP24.Services.Models;
using TP24.Services.Services;

namespace TP24.Data.Tests;

public class Tests
{
    private PayloadService _service;
    private Mock<IRepository> _mockRepository;
    private Mock<IPayloadMapper> _mapper;
    
    
    [SetUp]
    public void Setup()
    {
        _mockRepository = new Mock<IRepository>();
        _mapper = new Mock<IPayloadMapper>();
        _service = new PayloadService(_mockRepository.Object, _mapper.Object);
    }

    [Test]
    public void AddPayload()
    {
        _mapper.Setup(o => o.MapToEntity(It.IsAny<PayloadRequest>())).Returns(new Payload());
        _mapper.Setup(o => o.MapToResponse(It.IsAny<Payload>())).Returns(new PayloadResponse() { Id = 1 });
        _service.AddPayload(new PayloadRequest());
        _mockRepository.Verify(x => x.AddPayload(It.IsAny<Payload>()));
    }
}