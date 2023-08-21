using TP24.Data.Interfaces;
using TP24.Services.Interfaces;
using TP24.Services.Models;

namespace TP24.Services.Services;

public class StatisticsService : IStatisticsService
{
    private readonly IStatisticsRepository _repository;

    public StatisticsService(IStatisticsRepository repository)
    {
        _repository = repository;
    }
    public StatisticsResponse GetStatisticsForOpenAndClosedInvoices()
    {
        var stats = _repository.GetOpenAndClosedInvoiceCounts();
        
        return new StatisticsResponse()
        {
            TotalClosedInvoices = stats.TotalClosedInvoices,
            TotalOpenInvoices = stats.TotalOpenInvoices
        };
    }
}