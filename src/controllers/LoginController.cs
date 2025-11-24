using Microsoft.AspNetCore.Mvc;

namespace programacionIII_crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Validación simple
            if (request.Email == "admin@test.com" && request.Password == "123456")
            {
                return Ok(new { success = true, message = "Login exitoso", token = "token-123456" });
            }
            
            return Unauthorized(new { success = false, message = "Credenciales inválidas" });
        }
    }

    public class LoginRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
