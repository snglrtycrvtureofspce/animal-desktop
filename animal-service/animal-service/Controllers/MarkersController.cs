using animal_service.Data;
using animal_service.Models;
using Microsoft.AspNetCore.Mvc;

namespace animal_service.Controllers;

[Route("api/markers")]
[ApiController]
public class MarkersController : ControllerBase
{
    private readonly AnimalsDbContext _context;

    public MarkersController(AnimalsDbContext context)
    {
        _context = context;
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddMarker(MarkerEntity marker)
    {
        try
        {
            _context.Markers.Add(marker);
            await _context.SaveChangesAsync();
            return Ok("Метка успешно добавлена");
        }
        catch (Exception ex)
        {
            return BadRequest($"Ошибка: {ex.Message}");
        }
    }
    
}