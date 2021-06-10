using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    /// <summary>
    /// A class to control the amount of beans we can fill in, and the amount that has been filled.
    /// </summary>
    class BeanContainer : IContainer
    {
        private int _fillLimit;
        private int _amountFilled;

        public int FillLimit
        {
            get { return _fillLimit; }
            set { _fillLimit = value; }
        }

        public int AmountFilled
        {
            get { return _amountFilled; }
            set { _amountFilled = value; }
        }

        public BeanContainer(int fillLimit, int amountFilled)
        {
            FillLimit = fillLimit;
            AmountFilled = amountFilled;
        }
    }
}
