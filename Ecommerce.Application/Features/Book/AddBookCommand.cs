using MediatR;

namespace Ecommerce.Application.Features.Book;


public abstract class AddBookCommand<TResponse> : IRequest<TResponse>;

public class AddBookCommandHandler<TCommand,TResponse> : IRequestHandler<AddBookCommand<TResponse>,TResponse> 
{
    private IRequestHandler<AddBookCommand<TResponse>, TResponse> _requestHandlerImplementation;
    public Task<TResponse> Handle(AddBookCommand<TResponse> request, CancellationToken cancellationToken)
    {
        return _requestHandlerImplementation.Handle(request, cancellationToken);
    }
}