using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class QueueUnderflowException : ApplicationException
    {
        private static string msg = "Queue is empty!";
        public QueueUnderflowException(string s) : base(msg) { }
    }
}
