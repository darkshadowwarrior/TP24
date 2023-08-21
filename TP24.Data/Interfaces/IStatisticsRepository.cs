using TP24.Data.Entities;

namespace TP24.Data.Interfaces;

public interface IStatisticsRepository
{
    void UpdateTotalOpenInvoicesCount();
    PayloadStatistics GetOpenAndClosedInvoiceCounts();
}