using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_exam_done
{
    class Elevator
    {
        public static double SumOfWeight;
        private double MaxWeight;

        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)

        {

            this.MaxWeight = maxWeight;
            Passenger[] Occupants = new Passenger[3];
            Occupants = new Passenger[maxOccupants];
            
              

        }

        public Elevator()
        {
        }

        public double GetCurrentWeight()

        {

            return this.MaxWeight;

        }
        public double IsOverMaxCapacity()

        {
            double MaxWeight =4;
            if(this.MaxWeight> MaxWeight)
            {
                System.Console.WriteLine("The Elevator is Over Load");
            }
            else
            {
                System.Console.WriteLine("the elevator has maxweight");
            }

            return this.MaxWeight;



        }
        public void AddOccupant(Passenger passenger, int index)
        {
           

            Occupants = new Passenger[3];
            this.Occupants[index] = passenger;
        }
         
        




    }
}
