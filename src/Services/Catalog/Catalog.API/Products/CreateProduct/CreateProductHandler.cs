using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string name, List<string> Category, string description, string imageFile, decimal price) 
        : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid id);
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            //Business logic goes here to create a product
            throw new NotImplementedException();
        }
    }
}
