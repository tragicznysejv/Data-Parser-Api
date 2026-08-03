using System.Text.Json;
using ParserDanychApi.Models;
using System.Collections.Generic;
using System.Text;
namespace ParserDanychApi.Services
{
    public class ParserService : IParserService
    {
        public ParseResponse ParseData(ParseRequest request)
        {
            string decodeString;
            try
            {
                byte[] data = Convert.FromBase64String(request.Content);
                decodeString = Encoding.UTF8.GetString(data);
            }
            catch (FormatException)
            {
                throw new ArgumentException("Unknow format, please put Base64");

            }
            return request.Type switch
            {
                LoadType.CSV => ParseCsv(decodeString),
                LoadType.INTERNAL_JSON => ParseJson(decodeString),
                _ => throw new ArgumentException("Unsupported data type")
            };
        }

            private ParseResponse ParseCsv(string content)
        {
            var lines = content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var parsedData = new List<string[]>();

            foreach(var line in lines)
            {
                parsedData.Add(line.Split(','));
            }
            return new ParseResponse
            {
                Success = true,
                Count = parsedData.Count,
                Data = parsedData
            };

        }
        private ParseResponse ParseJson(string content)
        {
            try
            {
                var element = JsonSerializer.Deserialize<JsonElement>(content);
                int count = element.ValueKind == JsonValueKind.Array ? element.GetArrayLength() : 1;

                return new ParseResponse
                {
                    Success = true,
                    Count = count,
                    Data = element
                };
            }
            catch (JsonException)
            {
                throw new ArgumentException("Decoded value is not proper format");
            }
        }
        
    }
}
