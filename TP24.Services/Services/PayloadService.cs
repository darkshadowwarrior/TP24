using TP24.Data.Entities;
using TP24.Data.Repositories;
using TP24.Services.Interfaces;
using TP24.Services.Models;

namespace TP24.Services.Services;

public class PayloadService : IPayloadService
{
    private readonly IRepository _repository;
    private readonly IPayloadMapper _mapper;

    public PayloadService(IRepository repository, IPayloadMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public PayloadResponse AddPayload(PayloadRequest payload)
    {
        var response = _repository.AddPayload(_mapper.MapToEntity(payload));
        
        return _mapper.MapToResponse(response);
    }

    public IEnumerable<Payload> GetPayloads()
    {
        return _repository.GetPayloads();
    }
}