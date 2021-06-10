using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    class Filter
    {
        private int _filterUsage;

        public int FilterUsage
        {
            get { return _filterUsage; }
            set { _filterUsage = value; }
        }

        public Filter(int filterUsage)
        {
            FilterUsage = filterUsage;
        }
    }
}
