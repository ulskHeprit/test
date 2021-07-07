using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class LineNotEmpty : Exception
    {
        public LineNotEmpty(int i):base("На " +i+ " линии уже стоит поезд.")
        {

        }
    }
}
