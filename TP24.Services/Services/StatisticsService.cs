using TP24.Data.Interfaces;
using TP24.Services.Interfaces;
using TP24.Services.Models;

namespace TP24.Services.Services;

public class StatisticsService : IStatisticsService
{
    private readonly IStatisticsRepository _repository;
    private readonly IPayloadRepository _payloadRepository;

    public StatisticsService(IStatisticsRepository repository, IPayloadRepository payloadRepository)
    {
        _repository = repository;
        _payloadRepository = payloadRepository;
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

    public double GetTotalOpenDebtLeftToPay()
    {
        return _payloadRepository.GetTotalOpenDebtLeftToPay();
    }
}