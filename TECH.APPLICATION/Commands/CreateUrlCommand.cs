using MediatR;

namespace TECH.APPLICATION.Commands;

public record CreateUrlCommand(string LongUrl) : IRequest<string>;

public class CreateUrlCommandHandler : IRequestHandler<CreateUrlCommand, string>
{
    public async Task<string> Handle(CreateUrlCommand request, CancellationToken cancellationToken)
    {
        var shortCode = Guid.NewGuid().ToString().Substring(0, 6);
        return await Task.FromResult(shortCode);
    }
}