using Moq;
using TP24.Data.Entities;
using TP24.Data.Interfaces;
using TP24.Services.Services;

namespace TP24.Data.Tests;

public class StatisticsServiceTests
{
    private Mock<IStatisticsRepository> _mockStatisticsRepository;
    private Mock<IPayloadRepository> _mockPayloadRepository;
    
    private StatisticsService _service;
    
    [SetUp]
    public void Setup()
    {
        _mockStatisticsRepository = new Mock<IStatisticsRepository>();
        _mockPayloadRepository = new Mock<IPayloadRepository>();
        _service = new StatisticsService(_mockStatisticsRepository.Object, _mockPayloadRepository.Object);
    }

    [Test]
    public void GetStatisticsForOpenAndClosedInvoices()
    {
        _mockStatisticsRepository.Setup(o => o.GetOpenAndClosedInvoiceCounts()).Returns(new PayloadStatistics()
            { TotalClosedInvoices = 1, TotalOpenInvoices = 0 });
        
        _service.GetStatisticsForOpenAndClosedInvoices();

        _mockStatisticsRepository.Verify(o => o.GetOpenAndClosedInvoiceCounts(), Times.Once);
    }
    
    [Test]
    public void GetTotalOpenDebtLeftToPay()
    {
        _mockPayloadRepository.Setup(o => o.GetTotalOpenDebtLeftToPay()).Returns(400);
        
        _service.GetTotalOpenDebtLeftToPay();

        _mockPayloadRepository.Verify(o => o.GetTotalOpenDebtLeftToPay(), Times.Once);
    }
}