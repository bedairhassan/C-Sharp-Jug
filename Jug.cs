using System;

namespace C_
{
    class Jug
    {
        // private variables
        private static int id_generator;

        private int id, maxCapacity, current;


        // constructors 
        static Jug() // constructor 
        {
            id_generator = 1;
        }

        public Jug() // constructor 
        {
            this.id = id_generator++;
        }

        public Jug(int current, int maxCapacity) :base() 
        {
            this.current = current;
            this.maxCapacity = maxCapacity;
        }

        public Jug(Jug previousJug){

            this.current=previousJug.current;
            this.maxCapacity=previousJug.maxCapacity;
            this.id=previousJug.id;
        }

        // functions
        public void fillFull()
        {
            this.current = this.maxCapacity;
        }

        public void Display(Jug jug2)
        {
            String sol= "(" + this.current + "," + jug2.current + ")";
            Console.WriteLine(sol);
            //return sol;
        }

        
    }
}
