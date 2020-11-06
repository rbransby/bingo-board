using System;
using System.Collections.Generic;

namespace bingo_board_model
{
    public class BingoBoard
    {
        public string Id {get;set;}
        public string Title {get;set;}
        public IEnumerable<BingoBoardItem> BingoBoardItems {get;set;}
    }
}
