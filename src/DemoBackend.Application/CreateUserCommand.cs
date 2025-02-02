using MediatR;


namespace DemoBackend.Application;

public class CreateUserCommand : IRequest<Guid>
{
    public required  string Name { get; set; }
    public required string Email { get; set; }
}
