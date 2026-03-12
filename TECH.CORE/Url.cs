namespace TECH.CORE;

public class Url
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string LongUrl { get; set; } = string.Empty;
    public string ShortCode { get; set; } = string.Empty;
    
    public void ValidarUrl(string url)
    {
        if (!Uri.TryCreate(url, UriKind.Absolute, out _))
            throw new ArgumentException("URL inválida!");
    }
}