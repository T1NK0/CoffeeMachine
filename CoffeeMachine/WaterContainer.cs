using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    /// <summary>
    /// A class to control the fill limit of the water container and the amount that has been filled
    /// </summary>
    class WaterContainer : IContainer
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

        public WaterContainer(int fillLimit, int amountFilled)
        {
            FillLimit = fillLimit;
            AmountFilled = amountFilled;
        }
    }
}
