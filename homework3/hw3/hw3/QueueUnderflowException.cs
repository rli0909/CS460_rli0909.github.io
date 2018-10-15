using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class QueueUnderflowException : SystemException
    {
        private static string msg = "Queue is empty!";
        public QueueUnderflowException(string s) : base(msg) { }
    }
}
