using System;
using System.Collections;

namespace C_
{
    class Product
    {
        public Jug jug1, jug2;
        public String description;

        public Product(Jug jug1, Jug jug2) { this.jug1 = jug1; this.jug2 = jug2; }


        // Copy constructor.
        public Product(Product previousProduct)
        {
            this.jug1 = new Jug(previousProduct.jug1);
            this.jug2 = new Jug(previousProduct.jug2);
        }

        public static void Display(Product initialState,ArrayList products,Boolean DisplayDescription){

            initialState.DisplayTwoJugs();

            foreach(Product p in products){

                p.DisplayTwoJugs(DisplayDescription);
            }
        }

        public static ArrayList Cases(Product p)
        {
            ArrayList products = new ArrayList();

            //p.jug1.Display(p.jug2); // given
            //Console.WriteLine("\n");


            // full1
            Product p1 = new Product(p);
            p1.jug1.fillFull();
            //p1.jug1.Display(p1.jug2);
            p1.description="full Left";
            products.Add(p1);

            // full2 
            Product p2 = new Product(p);
            p2.jug2.fillFull();
            //p2.jug1.Display(p2.jug2);
            p2.description="full Right";
            products.Add(p2);

            // empty1
            Product p3 = new Product(p);
            p3.jug1.Empty();
            //p3.jug1.Display(p3.jug2);
            p3.description="empty Left";
            products.Add(p3);

            // empty2
            Product p4 = new Product(p);
            p4.jug2.Empty();
            //p4.jug1.Display(p4.jug2);
            p4.description="empty Right";
            products.Add(p4);

            // full-swap
            Product p5 = Product.full_swap(p);
            //p5.jug1.Display(p5.jug2);
            p5.description="Full Swap";
            products.Add(p5);

            return products;
        }


        static Product full_swap(Product q)
        {
            Jug jugRET = Jug.MaxCapacityByObject(new Jug[2] { q.jug1, q.jug2 });

            Product p = new Product(q);

            int remaining=0;
            if(p.FindSum()>jugRET.maxCapacity){
            remaining = p.FindSum() - jugRET.maxCapacity; // needs exception
            }

            //System.Console.WriteLine("p.findsum is "+p.FindSum());
            //System.Console.WriteLine("jugret maxcap is "+jugRET.maxCapacity);
            int FindSumTemp = p.FindSum();
            p.EmptyBoth();
            if (p.jug1.id == jugRET.id)
            {                
                if(FindSumTemp>=p.jug1.maxCapacity){
                    p.jug1.fillTillmaxCapacity();
                }else{
                    p.jug1.current=FindSumTemp;
                }

                if (p.jug2.maxCapacity < remaining)
                {
                    p.jug2.fillTillmaxCapacity();

                }
                else
                {
                    p.jug2.current = remaining; // as long as remaining <= than maxCapacity
                }
            }
            else
            {
                if(FindSumTemp>=p.jug2.maxCapacity){
                    p.jug2.fillTillmaxCapacity();
                }else{
                    p.jug2.current=FindSumTemp;
                }

                if (p.jug1.maxCapacity < remaining)
                {
                    p.jug1.fillTillmaxCapacity();
                }
                else
                {
                    p.jug1.current = remaining;
                }
            }

            return p;
        }

        public int FindSum()
        {

            return this.jug1.current + this.jug2.current;
        }

        public void EmptyBoth()
        {

            this.jug1.Empty();
            this.jug2.Empty();
        }

        public void DisplayTwoJugs(Boolean DisplayDescription=false){

            String Send = DisplayDescription?this.description:"";
            //System.Console.WriteLine("this description is "+this.description);
            this.jug1.Display(this.jug2,Send);
        }

        public void Display()
        {
            this.jug1.DisplayAll();
            Console.WriteLine("\n");
            this.jug2.DisplayAll();
        }
    }
}
