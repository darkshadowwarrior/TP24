using TP24.Data.Entities;

namespace TP24.Data.Repositories;

public interface IRepository
{
    void AddPayload(Payload payload);
}