using TP24.Data.Entities;
using TP24.Services.Interfaces;
using TP24.Services.Models;
using TP24.Services.Services;

namespace TP24.Services.Mappers;

public class PayloadMapper : IPayloadMapper
{
    public Payload MapToEntity(PayloadRequest payload)
    {
        return new Payload()
        {
            Id = payload.Id,
            Reference = payload.Reference,
            CurrencyCode = payload.CurrencyCode,
            IssueDate = payload.IssueDate,
            OpeningValue = payload.OpeningValue,
            PaidValue = payload.PaidValue,
            DueDate = payload.DueDate,
            ClosedDAte = payload.ClosedDAte,
            Cancelled = payload.Cancelled,
            DebtorName = payload.DebtorName,
            DebtorReference = payload.DebtorReference,
            DebtorAddress1 = payload.DebtorAddress1,
            DebtorAddress2 = payload.DebtorAddress2,
            DebtorTown = payload.DebtorTown,
            DebtorState = payload.DebtorState,
            DebtorZip = payload.DebtorZip,
            DebtorCountryCode = payload.DebtorCountryCode,
            DebtorRegistrationNumber = payload.DebtorRegistrationNumber
        };
    }

    public PayloadResponse MapToResponse(Payload payload)
    {
        return new PayloadResponse()
        {
            Id = payload.Id,
            Reference = payload.Reference,
            CurrencyCode = payload.CurrencyCode,
            IssueDate = payload.IssueDate,
            OpeningValue = payload.OpeningValue,
            PaidValue = payload.PaidValue,
            DueDate = payload.DueDate,
            ClosedDAte = payload.ClosedDAte,
            Cancelled = payload.Cancelled,
            DebtorName = payload.DebtorName,
            DebtorReference = payload.DebtorReference,
            DebtorAddress1 = payload.DebtorAddress1,
            DebtorAddress2 = payload.DebtorAddress2,
            DebtorTown = payload.DebtorTown,
            DebtorState = payload.DebtorState,
            DebtorZip = payload.DebtorZip,
            DebtorCountryCode = payload.DebtorCountryCode,
            DebtorRegistrationNumber = payload.DebtorRegistrationNumber
        };
    }
}