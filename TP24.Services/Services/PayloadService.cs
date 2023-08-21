using TP24.Data.Entities;
using TP24.Data.Interfaces;
using TP24.Data.Repositories;
using TP24.Services.Interfaces;
using TP24.Services.Models;

namespace TP24.Services.Services;

public class PayloadService : IPayloadService
{
    private readonly IPayloadRepository _payloadRepository;
    private readonly IPayloadMapper _mapper;
    private readonly IStatisticsRepository _statisticsRepository;

    public PayloadService(IPayloadRepository payloadRepository, IPayloadMapper mapper, IStatisticsRepository statisticsRepository)
    {
        _payloadRepository = payloadRepository;
        _mapper = mapper;
        _statisticsRepository = statisticsRepository;
    }

    public PayloadResponse AddPayload(PayloadRequest payload)
    {
        var response = _payloadRepository.AddPayload(_mapper.MapToEntity(payload));
        _statisticsRepository.UpdateTotalOpenInvoicesCount();
        
        return _mapper.MapToResponse(response);
    }

    public IEnumerable<Payload> GetPayloads()
    {
        return _payloadRepository.GetPayloads();
    }
}