using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    class CoffeeMachine
    {

        public IContainer MachineBeanContainer { get; set; }
        public IContainer MachineWaterContainer { get; set; }
        public Filter MachineFilter { get; set; }

        private bool _powerButton;

        public bool PowerButton
        {
            get { return _powerButton; }
            set { _powerButton = value; }
        }

        public CoffeeMachine(IContainer ingredientContainer, IContainer liquidContainer, Filter filter, bool powerButton)
        {
            MachineBeanContainer = ingredientContainer;
            MachineWaterContainer = liquidContainer;
            MachineFilter = filter;
            PowerButton = powerButton;
        }

        public void CoffeeMode(BeanContainer coffeeContainer)
        {
            MachineBeanContainer = coffeeContainer;

        }

        public void TeaMode(TeaContainer teaContainer)
        {
            MachineBeanContainer = teaContainer;
        }
    }
}
