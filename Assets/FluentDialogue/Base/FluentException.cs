using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent
{
    public class FluentException : Exception
    {
        public FluentException(string message)
                : base(message)
        {
        }
    }
}
