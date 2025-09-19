using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads_Homework
{
    public class User
    {
        public string name { get; set; }

        public override string ToString()
        {
            return $"Name {name}";
        }
    }
}
