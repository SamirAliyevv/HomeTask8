using System;
using System.Collections.Generic;
using System.Text;

namespace demo_02
{
    internal class Car : Vehicle
    {

        public int FuelCapacity;
        public int CurrentFuel;

        public Car(int fuelcapacity,int currentful,string brand,string model):base(brand,model)
        {
            this.FuelCapacity = fuelcapacity;
            this.CurrentFuel = currentful;

        }

        public bool AddFuel(int benzin)
        {
            if (CurrentFuel+benzin<=FuelCapacity)
            {

                return true;
            }
            return false;
        }
        
            
        



    }
        
   
   
    
        

    
    
}
