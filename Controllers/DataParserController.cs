using Microsoft.AspNetCore.Mvc;
using ParserDanychApi.Models;
using ParserDanychApi.Services;
using System;

namespace ParserDanychApi.Controllers
{
    [ApiController]
    [Route("api/v1/parse-content")]
    public class DataParserController : Controller
    {
        private readonly IParserService _parserService;

        public DataParserController(IParserService parserService)
        {
            _parserService = parserService;
        }

        [HttpPost]
        public IActionResult ParseContent([FromBody] ParseRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { Error = "Invalid request type." });
            }
            try
            {
                var response = _parserService.ParseData(request);
                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { Error = "An unexpected server error occured." });
            }
        }
    }
}