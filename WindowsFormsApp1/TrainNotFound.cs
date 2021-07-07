using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TrainNotFound : Exception
    {
        public TrainNotFound(int i):base("На "+i+" линии нет поезда.")
        {

        }
    }
}
