using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using Moq;
using TP24.Data.Entities;
using TP24.Data.Repositories;
using TP24.Services;

namespace TP24.Data.Tests;

public class Tests
{
    private PayloadService _service;
    private Mock<IRepository> _mockRepository;
    
    
    [SetUp]
    public void Setup()
    {
        _mockRepository = new Mock<IRepository>();
        _service = new PayloadService(_mockRepository.Object);
    }

    [Test]
    public void Test1()
    {
        _service.AddPayload(new Payload());
        _mockRepository.Verify(x => x.AddPayload(It.IsAny<Payload>()));
    }
}