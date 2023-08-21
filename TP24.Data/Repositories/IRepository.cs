using TP24.Data.Entities;

namespace TP24.Data.Repositories;

public interface IRepository
{
    Payload AddPayload(Payload payload);
    IEnumerable<Payload> GetPayloads();
}