using MediatR;

namespace BuildingBlocks;
public interface ICommand<out TResponse> : IRequest<TResponse>
{
    
}  

public interface ICommand : ICommand<Unit>
{
    
}

