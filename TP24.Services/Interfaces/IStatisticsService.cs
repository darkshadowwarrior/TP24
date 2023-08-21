using TP24.Services.Models;

namespace TP24.Services.Interfaces;

public interface IStatisticsService
{
    StatisticsResponse GetStatisticsForOpenAndClosedInvoices();
}