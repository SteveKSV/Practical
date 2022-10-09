using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Online_Radio_Database
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        private const int MinSecondsValue = 0;
        private const int MaxSecondsValue = 59;

        public override string Message => $"Song seconds should be between {MinSecondsValue} and {MaxSecondsValue}.";
    }

}
