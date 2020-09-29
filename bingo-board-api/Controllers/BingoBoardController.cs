using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bingo_board_model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace bingo_board_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BingoBoardController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<BingoBoard> _logger;

        // The Web API will only accept tokens 1) for users, and 2) having the "access_as_user" scope for this API
        static readonly string[] scopeRequiredByApi = new string[] { "access_as_user" };

        public BingoBoardController(ILogger<BingoBoard> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public BingoBoard Get(string id)
        {
            var bingoBoard = new BingoBoard();
            bingoBoard.BingoBoardItems = new List<BingoBoardItem>();
            var random = new Random();
            while (bingoBoard.BingoBoardItems.Count() < 25)
            {
                bingoBoard.BingoBoardItems = bingoBoard.BingoBoardItems.Append(DefaultItems[random.Next(5)]);
            }         

            return bingoBoard;   
        }

        private BingoBoardItem[] DefaultItems = new BingoBoardItem[5] {
            new BingoBoardItem() {Text = "The juice is worth the squeeze"},
            new BingoBoardItem() {Text = "Blah blah blah"},
            new BingoBoardItem() {Text = "Can you see my screen?"},
            new BingoBoardItem() {Text = "My crappy test data"},
            new BingoBoardItem() {Text = "Someone asks a question over voice and not chat"},
        };
    }
}
