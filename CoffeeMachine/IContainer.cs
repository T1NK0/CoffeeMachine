using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    public interface IContainer
    {
        public int FillLimit { get; set; }
        public int AmountFilled { get; set; }
    }
}
