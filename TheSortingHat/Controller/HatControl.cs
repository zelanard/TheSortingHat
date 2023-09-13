using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSortingHat.Model;
using TheSortingHat.View;

namespace TheSortingHat.Controller
{
    internal class HatControl
    {
        private SortingHat SortingHat { get; set; }

        public void Start()
        {
            while(true)
            {
                SortingHat = new SortingHat();
                ViewCollege.PrintCollege(SortingHat.ToString());
            }
        }
    }
}
