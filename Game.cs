using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Bruner_Zach
{
    internal class Game
    {

        public string title, genre;
        // uses the tile and genre to input into the command prompt Unknown title and Casaul 
        public Game(string titleParam = "Unknown Title", string genreParam = "Casual")
        {
            title = titleParam;
            genre = genreParam;
        }
    }
}
