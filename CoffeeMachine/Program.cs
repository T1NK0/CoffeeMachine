using System;
using System.Threading;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Create our coffee machine, with 2 i containers we define as water container and bean container, a filter and a power button (set to false).
            /// </summary>
            
            CoffeeMachine coffeeMachine = new CoffeeMachine(new WaterContainer(100, 0), new BeanContainer(100, 0), new Filter(0), false);

            //Fills our coffeemachine with water.
            coffeeMachine.MachineWaterContainer.AmountFilled = 100;
            Console.WriteLine("Vandmængde: " + coffeeMachine.MachineWaterContainer.AmountFilled);

            //Fills our coffeemachine with beans
            coffeeMachine.MachineBeanContainer.AmountFilled = 100;
            Console.WriteLine("Bønnemængde: " + coffeeMachine.MachineBeanContainer.AmountFilled);

            //Set filterUsage to 0 to imply a new filter has been added.
            coffeeMachine.MachineFilter.FilterUsage = 0;
            Console.WriteLine("Filteropbrugt: " + coffeeMachine.MachineFilter.FilterUsage);

            //Set power button to false to imply machine is off
            coffeeMachine.PowerButton = false;
            Console.WriteLine(coffeeMachine.PowerButton);

            Console.WriteLine("----------------------");

            Console.WriteLine("Brewing Coffee....");

            Thread.Sleep(2000);

            Console.WriteLine("Coffee has been brewed");

            Console.WriteLine("---------------------");

            //Set power button to false to imply machine is off
            coffeeMachine.PowerButton = true;
            Console.WriteLine(coffeeMachine.PowerButton);

            //Fills our coffeemachine with water.
            coffeeMachine.MachineWaterContainer.AmountFilled -= 20;
            Console.WriteLine(coffeeMachine.MachineWaterContainer.AmountFilled);

            //Fills our coffeemachine with beans
            coffeeMachine.MachineBeanContainer.AmountFilled -= 10;
            Console.WriteLine(coffeeMachine.MachineBeanContainer.AmountFilled);

            //Set filterUsage to 0 to imply a new filter has been added.
            coffeeMachine.MachineFilter.FilterUsage += 10;
            Console.WriteLine(coffeeMachine.MachineFilter.FilterUsage);

            //-------------- TEA MODE ---------------//

            //Could take a user input to see weather the user presses 1 or 2 for either coffee or tea, then run the methods in coffemachine to define wether to make Coffee or tea.
            //

            Console.WriteLine("----- TEA MODE -----");


            coffeeMachine.TeaMode(new TeaContainer(100, 0));

            //Fills our coffeemachine with water.
            coffeeMachine.MachineWaterContainer.AmountFilled = 100;
            Console.WriteLine("Vandmængde: " + coffeeMachine.MachineWaterContainer.AmountFilled);

            //Fills our coffeemachine with beans
            coffeeMachine.MachineBeanContainer.AmountFilled = 100;
            Console.WriteLine("Themængde: " + coffeeMachine.MachineBeanContainer.AmountFilled);

            //Set filterUsage to 0 to imply a new filter has been added.
            coffeeMachine.MachineFilter.FilterUsage = 0;
            Console.WriteLine("Filteropbrugt: " + coffeeMachine.MachineFilter.FilterUsage);

            //Set power button to false to imply machine is off
            coffeeMachine.PowerButton = false;
            Console.WriteLine(coffeeMachine.PowerButton);

            Console.WriteLine("----------------------");

            Console.WriteLine("Brewing Tea....");

            Thread.Sleep(2000);

            Console.WriteLine("Tea has been brewed");

            Console.WriteLine("---------------------");

            //Set power button to false to imply machine is off
            coffeeMachine.PowerButton = true;
            Console.WriteLine(coffeeMachine.PowerButton);

            //Fills our coffeemachine with water.
            coffeeMachine.MachineWaterContainer.AmountFilled -= 20;
            Console.WriteLine(coffeeMachine.MachineWaterContainer.AmountFilled);

            //Fills our coffeemachine with beans
            coffeeMachine.MachineBeanContainer.AmountFilled -= 10;
            Console.WriteLine(coffeeMachine.MachineBeanContainer.AmountFilled);

            //Set filterUsage to 0 to imply a new filter has been added.
            coffeeMachine.MachineFilter.FilterUsage += 10;
            Console.WriteLine(coffeeMachine.MachineFilter.FilterUsage);
        }
    }
}
