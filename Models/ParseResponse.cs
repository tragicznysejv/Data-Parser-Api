namespace ParserDanychApi.Models
{
    public class ParseResponse
    {
        public bool Success {  get; set; }
        public int Count { get; set; }
        public object? Data { get; set; }
    }
}
