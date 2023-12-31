using Microsoft.AspNetCore.Mvc;
using TP24.Services.Interfaces;
using TP24.Services.Models;

namespace TP24.API.Controllers;

[ApiController]
[Route("[controller]")]
public class StatisticsController : ControllerBase
{
    private readonly IStatisticsService _statisticsService;

    public StatisticsController(IStatisticsService statisticsService)
    {
        _statisticsService = statisticsService;
    }

    [HttpGet("GetStatisticsForOpenAndClosedInvoices")]
    public StatisticsResponse GetStatisticsForOpenAndClosedInvoices()
    {
        return _statisticsService.GetStatisticsForOpenAndClosedInvoices();
    }

    [HttpGet("GetTotalOpenDebtLeftToPay")]
    public double GetTotalOpenDebtLeftToPay()
    {
        return _statisticsService.GetTotalOpenDebtLeftToPay();
    }
}