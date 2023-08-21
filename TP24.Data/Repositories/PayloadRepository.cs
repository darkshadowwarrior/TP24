using TP24.Data.Contexts;
using TP24.Data.Entities;
using TP24.Data.Interfaces;

namespace TP24.Data.Repositories;

public class PayloadRepository : IPayloadRepository
{
    private readonly TpContext _context;

    public PayloadRepository(TpContext context)
    {
        _context = context;
    }
    
    public Payload AddPayload(Payload payload)
    {
        var entity = _context.Payloads.Find(payload.Id);
        if (entity != null)
        {
            throw new Exception();
        }

        var response = _context.Payloads.Add(payload).Entity;
        _context.SaveChanges();
        
        return MapResponseToPayload(response);
    }
    
    public IEnumerable<Payload> GetPayloads()
    {
        return _context.Payloads;
    }

    public Payload UpdatePayload(Payload payload)
    {
        
        var response = _context.Payloads.Update(payload).Entity;
        _context.SaveChanges();
        
        return MapResponseToPayload(response);
    }

    public Payload GetPayloadById(int payloadId)
    {
        var entity = _context.Payloads.Find(payloadId);
        if (entity == null)
        {
            throw new Exception();
        };

        return MapResponseToPayload(entity);
    }

    private static Payload MapResponseToPayload(Payload response)
    {
        return new Payload()
        {
            Id = response.Id,
            Reference = response.Reference,
            CurrencyCode = response.CurrencyCode,
            IssueDate = response.IssueDate,
            OpeningValue = response.OpeningValue,
            PaidValue = response.PaidValue,
            DueDate = response.DueDate,
            ClosedDate = response.ClosedDate,
            Cancelled = response.Cancelled,
            DebtorName = response.DebtorName,
            DebtorReference = response.DebtorReference,
            DebtorAddress1 = response.DebtorAddress1,
            DebtorAddress2 = response.DebtorAddress2,
            DebtorTown = response.DebtorTown,
            DebtorState = response.DebtorState,
            DebtorZip = response.DebtorZip,
            DebtorCountryCode = response.DebtorCountryCode,
            DebtorRegistrationNumber = response.DebtorRegistrationNumber
        };
    }

}