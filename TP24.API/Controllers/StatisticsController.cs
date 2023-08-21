using Microsoft.AspNetCore.Mvc;
using TP24.Services.Interfaces;
using TP24.Services.Models;

namespace TP24.API.Controllers;

public class StatisticsController
{
    private readonly IStatisticsService _statisticsService;
    private readonly IPayloadService _payloadService;

    public StatisticsController(IStatisticsService statisticsService, IPayloadService payloadService)
    {
        _statisticsService = statisticsService;
        _payloadService = payloadService;
    }

    [HttpGet]
    public StatisticsResponse GetStatisticsForOpenAndClosedInvoices()
    {
        var payloads = _payloadService.GetPayloads();
        return _statisticsService.GetStatisticsForOpenAndClosedInvoices(payloads.ToList());
    }
}