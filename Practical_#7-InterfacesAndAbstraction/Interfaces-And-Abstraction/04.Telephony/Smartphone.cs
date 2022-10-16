using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        public string Call(string phoneNumber)
        {
            int count = 0;
               foreach(char c in phoneNumber)
                {
                    if (char.IsDigit(c))
                    {
                        count++;
                    }
                }
            if(count == phoneNumber.Length)
            {
                return "Calling... " + phoneNumber;
            } else
            {
                return "Invalid number!";
            }
        }

        public string Browse(string browsingUrl)
        {
            int count = 0;
            foreach (char c in browsingUrl)
            {
                if (!char.IsDigit(c))
                {
                    count++;
                }
            }
            if (count == browsingUrl.Length)
            {
                return "Browsing: " + browsingUrl;
            }
            else
            {
                return "Invalid URL!";
            }
        }
    }
}
