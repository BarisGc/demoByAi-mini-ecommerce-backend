using DemoBackend.Application.Interfaces.Repositories;
using DemoBackend.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UsersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await _userRepository.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> Create(User user)
    {
        await _userRepository.AddAsync(user);
        return Ok(user);
    }
}
