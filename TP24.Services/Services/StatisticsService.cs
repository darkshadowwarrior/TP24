using TP24.Data.Entities;
using TP24.Services.Interfaces;
using TP24.Services.Models;

namespace TP24.Services.Services;

public class StatisticsService : IStatisticsService
{
    public StatisticsResponse GetStatisticsForOpenAndClosedInvoices(List<Payload> payloads)
    {
        var totalClosedInvoices = payloads.Count(o => o.PaidValue.Equals(o.OpeningValue));
        var totalOpenInvoices = payloads.Count(o => !o.PaidValue.Equals(o.OpeningValue));
        return new StatisticsResponse() { TotalClosedInvoices = totalClosedInvoices, TotalOpenInvoices = totalOpenInvoices};
    }
}