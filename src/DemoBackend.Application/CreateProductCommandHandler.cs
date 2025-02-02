using DemoBackend.Domain.Entities;
using MediatR;


namespace DemoBackend.Application;

public class CreateProductHandler : IRequestHandler<CreateProductCommand, Guid>
{
    private readonly IProductRepository _repository;

    public CreateProductHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product { Id = Guid.NewGuid(), Name = request.Name, Price = request.Price };
        await _repository.AddAsync(product);
        return product.Id;
    }
}
