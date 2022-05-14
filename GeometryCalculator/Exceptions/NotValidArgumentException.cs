using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCunningFox.Planimetry.Exceptions
{
    public class NotValidArgumentException : ArgumentException
    {
        public NotValidArgumentException()
            : base() { }
        public NotValidArgumentException(string message)
            : base(message) { }
    }
}
