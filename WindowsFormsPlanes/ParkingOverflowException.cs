using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    public class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() : base("В ангаре нет свободных мест")
        { }
    }
}
