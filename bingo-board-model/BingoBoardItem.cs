using System;
using System.ComponentModel.DataAnnotations;

namespace bingo_board_model
{
    public class BingoBoardItem
    {
        [MaxLength(80)]
        public string Text {get;set;}
        public bool IsChecked {get;set;} = false;
    }
}
