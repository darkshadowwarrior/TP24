using FluentAssertions;
using TP24.Data.Entities;
using TP24.Services.Models;
using TP24.Services.Services;

namespace TP24.Data.Tests;

public class StatisticsServiceTests
{
    private StatisticsService _service;
    
    [SetUp]
    public void Setup()
    {
        _service = new StatisticsService();
    }

    [Test]
    public void GetStatisticsForOpenAndClosedInvoices_ReturnsResponseWithOneClosedAndZeroOpenInvoices()
    {
        var expected = new StatisticsResponse()
        {
            TotalClosedInvoices = 1,
            TotalOpenInvoices = 0
        };
        
        var actual = _service.GetStatisticsForOpenAndClosedInvoices(new List<Payload>()
        {
            new Payload()
            {
                OpeningValue = 123.00,
                PaidValue = 123.00
            }
        });

        actual.Should().BeEquivalentTo(expected);
    }
    
    [Test]
    public void GetStatisticsForOpenAndClosedInvoices_ReturnsResponseWithTwoClosedAndOneOpenInvoices()
    {
        var expected = new StatisticsResponse()
        {
            TotalClosedInvoices = 2,
            TotalOpenInvoices = 1
        };
        
        var actual = _service.GetStatisticsForOpenAndClosedInvoices(new List<Payload>()
        {
            new Payload()
            {
                OpeningValue = 123.00,
                PaidValue = 123.00
            },
            new Payload()
            {
                OpeningValue = 342.00,
                PaidValue = 123.00
            },
            new Payload()
            {
                OpeningValue = 342.00,
                PaidValue = 342.00
            }
        });

        actual.Should().BeEquivalentTo(expected);
    }
}