using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Online_Radio_Database
{
    public class InvalidArtistNameException : InvalidSongException
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 30;

        public override string Message { get { return $"Artist name should be between {MinNameLength} and {MaxNameLength} symbols."; } } 
    }

}
