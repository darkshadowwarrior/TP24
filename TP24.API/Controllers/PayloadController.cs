using Microsoft.AspNetCore.Mvc;
using TP24.Services.Interfaces;
using TP24.Services.Models;

namespace TP24.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PayloadController : ControllerBase
{
    private readonly IPayloadService _service;

    public PayloadController(IPayloadService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public PayloadResponse Add(PayloadRequest payload)
    {
        return _service.AddPayload(payload);
    }
}