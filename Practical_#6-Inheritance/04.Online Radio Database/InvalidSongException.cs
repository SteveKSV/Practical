using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Online_Radio_Database
{
    public class InvalidSongException : Exception
    {
        private string exceptionMessage = "Invalid song";

        public virtual string ExceptionMessage
        {
            set {this.exceptionMessage = value; }
        }

        public override string Message { get { return this.exceptionMessage; } }
    }
}
