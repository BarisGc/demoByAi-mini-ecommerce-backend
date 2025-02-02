using MediatR;

namespace DemoBackend.Application;

public record CreateProductCommand(string Name, decimal Price) : IRequest<Guid>;
