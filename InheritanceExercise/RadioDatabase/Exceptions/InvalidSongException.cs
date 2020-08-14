using System;
using System.Collections.Generic;
using System.Text;

namespace RadioDatabase
{
    public class InvalidSongException : FormatException

    {
        public InvalidSongException(string message= "Invalid song.") 
            : base(message)
        {
        }
    }
}
