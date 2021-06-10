using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    class TeaContainer : IContainer
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

        public TeaContainer(int fillLimit, int amountFilled)
        {
            FillLimit = fillLimit;
            AmountFilled = amountFilled;
        }
    }
}
