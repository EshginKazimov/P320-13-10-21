using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Helper
    {
        public string Demo { get; set; }
    }

    class Test : Helper
    {

    }

    class Main
    {
        public Main()
        {
            Helper h1 = new Helper();
        }
    }
}
