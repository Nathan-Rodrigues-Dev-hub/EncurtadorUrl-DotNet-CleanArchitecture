using TECH.APPLICATION.Commands;

namespace EncurtadorURL.Tests;

public class UrlTests
{
    [Fact]
    public async Task Handler_Deve_Gerar_Um_Codigo_De_6_Caracteres()
    {
        var handler = new CreateUrlCommandHandler();
        var command = new CreateUrlCommand("https://google.com");

        var result = await handler.Handle(command, CancellationToken.None);

        Assert.NotNull(result);
        Assert.Equal(6, result.Length);
    }
}