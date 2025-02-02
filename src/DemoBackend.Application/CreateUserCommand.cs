﻿using MediatR;

namespace DemoBackend.Application;

public class CreateUserCommand : IRequest<Guid>
{
    public string Name { get; set; }
    public string Email { get; set; }
}
