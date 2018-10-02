using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar
{
    class Car
    {

        AccubaterryController accubaterryController;

        public void setAccubaterryController(AccubaterryController accubaterryController)
        {
            this.accubaterryController = accubaterryController;
        }

        public void turnOnPower()
        {
            this.accubaterryController.turnOn();
        }
        public void turnOfPower()
        {
            this.accubaterryController.turnOff();
        }
        public Boolean powerIsReady()
        {
            return this.accubaterryController.accubatterryIsOn();
        }
    }
}
