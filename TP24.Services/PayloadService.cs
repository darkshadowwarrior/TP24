using TP24.Data.Entities;
using TP24.Data.Repositories;

namespace TP24.Services;

public class PayloadService
{
    private readonly IRepository _repository;

    public PayloadService(IRepository repository)
    {
        _repository = repository;
    }
    
    public void AddPayload(Payload payload)
    {
        _repository.AddPayload(payload);
    }
}