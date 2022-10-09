using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Online_Radio_Database
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        private const int MinMinutesValue = 0;
        private const int MaxMinutesValue = 14;

        public override string Message => $"Song minutes should be between {MinMinutesValue} and {MaxMinutesValue}.";
    }

}
