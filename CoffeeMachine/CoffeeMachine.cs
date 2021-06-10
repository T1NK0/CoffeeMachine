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

        public CoffeeMachine(IContainer beanContainer, IContainer waterContainer, Filter filter, bool powerButton)
        {
            MachineBeanContainer = beanContainer;
            MachineWaterContainer = waterContainer;
            MachineFilter = filter;
            PowerButton = powerButton;
        }
    }
}
