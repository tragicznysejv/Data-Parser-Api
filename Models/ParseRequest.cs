namespace ParserDanychApi.Models
{
    public class ParseRequest
    {
        public LoadType Type { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
