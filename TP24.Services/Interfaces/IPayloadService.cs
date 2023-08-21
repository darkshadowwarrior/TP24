using TP24.Services.Models;

namespace TP24.Services.Interfaces;

public interface IPayloadService
{
    PayloadResponse AddPayload(PayloadRequest payload);
}