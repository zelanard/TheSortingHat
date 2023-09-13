using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSortingHat.Controller;

namespace TheSortingHat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HatControl SortingHat = new HatControl();
            SortingHat.Start();
        }
    }
}
