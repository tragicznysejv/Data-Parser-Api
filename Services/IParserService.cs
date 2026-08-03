using ParserDanychApi.Models;
namespace ParserDanychApi.Services
{
    public interface IParserService
    {
        ParseResponse ParseData(ParseRequest request);
    }
}
