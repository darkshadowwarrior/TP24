using TP24.Data.Contexts;
using TP24.Data.Entities;
using TP24.Data.Interfaces;

namespace TP24.Data.Repositories;

public class StatisticsRepository : IStatisticsRepository
{
    private readonly TpContext _context;

    public StatisticsRepository(TpContext context)
    {
        _context = context;
    }
    
    public void UpdateTotalOpenInvoicesCount()
    {
        var stats = _context.Statistics.FirstOrDefault();

        if (stats == null)
        {
            stats = new PayloadStatistics();
        }
        
        stats.TotalOpenInvoices += 1;
        _context.Statistics.Update(stats);
        _context.SaveChanges();
    }

    public PayloadStatistics GetOpenAndClosedInvoiceCounts()
    {
        var payload = new PayloadStatistics();
        var stats = _context.Statistics.FirstOrDefault();
        
        if (stats == null) return payload;

        payload.TotalOpenInvoices = stats.TotalOpenInvoices;
        payload.TotalClosedInvoices = stats.TotalClosedInvoices;

        return payload;

    }

    public void UpdateTotalClosedInvoicesCount()
    {
        var stats = _context.Statistics.FirstOrDefault();

        if (stats == null)
        {
            stats = new PayloadStatistics();
        }
        
        stats.TotalOpenInvoices -= 1;
        stats.TotalClosedInvoices += 1;
        _context.Statistics.Update(stats);
        _context.SaveChanges();
    }
}