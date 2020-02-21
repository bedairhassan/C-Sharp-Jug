using System;
using System.Collections;

namespace C_
{
    class Jug
    {
        // private variables
        private static int id_generator;

        public int id, maxCapacity, current;

        public void DisplayID() { Console.WriteLine(this.id); }

        public void DisplayAll(){

            Console.WriteLine("id: "+this.id);
            Console.WriteLine("maxCapacity: "+this.maxCapacity);
            Console.WriteLine("current: "+this.current);
        }

        // constructors 
        static Jug() // constructor 
        {
            id_generator = 1;
        }

        // public Jug() // constructor 
        // {
        //     this.id = id_generator++;
        // }

        public Jug(int current, int maxCapacity)
        {
            this.id = id_generator++;
            this.current = current;
            this.maxCapacity = maxCapacity;
        }

        public Jug(Jug previousJug)
        {

            this.current = previousJug.current;
            this.maxCapacity = previousJug.maxCapacity;
            this.id = previousJug.id;
        }

        // functions
        public void fillTillmaxCapacity(){
            this.current=this.maxCapacity;
        }

        public void fillFull()
        {
            this.current = this.maxCapacity;
        }

        public void Display(Jug jug2,String DisplayDescription)
        {
            String sol = "(" + this.current + "," + jug2.current + ")";
            
            sol+=DisplayDescription==""?"":(" where case is "+DisplayDescription);
            //+((DisplayDescription.Length!=0)?" ,case is ":"")+DisplayDescription;
            Console.WriteLine(sol);
            //return sol;
        }

        public void Empty()
        {

            this.current = 0;
        }

        public static Jug MaxCapacityByObject(Jug[] jugs)
        {

            int maxCapacity = jugs[0].maxCapacity;
            Jug jugRET = jugs[0];

            foreach (Jug jug in jugs)
            {

                if (jug.maxCapacity > maxCapacity) 
                {
                    maxCapacity = jug.maxCapacity; // keep up!
                    jugRET = jug;
                }
            }

            return jugRET;
        }

        public static int MaxCapacityById(Jug[] jugs)
        {

            int maxCapacity = jugs[0].maxCapacity;
            int maxbyId = jugs[0].id;

            foreach (Jug jug in jugs)
            {

                if (jug.maxCapacity > maxCapacity) // guest>
                {
                    maxCapacity = jug.maxCapacity;
                    maxbyId = jug.id;
                }
            }

            return maxbyId;
        }

        public static int FindSum(Jug jug1, Jug jug2)
        {

            return jug1.current + jug2.current;
        }
    }
}
