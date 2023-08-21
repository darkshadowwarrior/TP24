using TP24.Data.Entities;

namespace TP24.Data.Interfaces;

public interface IPayloadRepository
{
    Payload AddPayload(Payload payload);
    IEnumerable<Payload> GetPayloads();
    Payload UpdatePayload(Payload isAny);
    Payload GetPayloadById(int payloadId);
}