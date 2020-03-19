using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_pc.Service.Exception
{
    public class NotFoundException : AccessViolationException
    {
        public NotFoundException(string message): base(message)
        {

        }
    }
}
