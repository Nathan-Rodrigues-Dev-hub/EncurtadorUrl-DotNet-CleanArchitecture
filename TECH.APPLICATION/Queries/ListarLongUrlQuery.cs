using MediatR;

namespace TECH.APPLICATION.Queries;

public record ListarLongUrlQuery(string ShortCode) : IRequest<string>;

public class ListarLongUrlQueryHandler : IRequestHandler<ListarLongUrlQuery, string>
{
    public async Task<string> Handle(ListarLongUrlQuery request, CancellationToken cancellationToken)
    {

        if (request.ShortCode == "96935f")
            return await Task.FromResult("https://www.youtube.com/watch?v=GYdGjQ_tY54");
            
        return await Task.FromResult("https://google.com");
    }
}