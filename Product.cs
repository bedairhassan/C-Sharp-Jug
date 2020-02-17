using System;

namespace C_
{
    class Product
    {
        private Jug jug1, jug2;

        public Product(Jug jug1, Jug jug2) { this.jug1 = jug1; this.jug2 = jug2; }


        // Copy constructor.
        public Product(Product previousProduct)
        {
            this.jug1 = new Jug(previousProduct.jug1);
            this.jug2 = new Jug(previousProduct.jug2);
        }

        public static void Cases(Product p)
        {
            p.jug1.Display(p.jug2);
            Console.WriteLine("\n");


            // full1
            Product p1 = new Product(p);
            p1.jug1.fillFull();
            p1.jug1.Display(p1.jug2);

            // full2 
            Product p2 = new Product(p);
            p2.jug2.fillFull();
            p2.jug1.Display(p2.jug2);

            // empty1
            Product p3 = new Product(p);
            p3.jug1.Empty();
            p3.jug1.Display(p3.jug2);

            // empty2
            Product p4 = new Product(p);
            p4.jug2.Empty();
            p4.jug1.Display(p4.jug2);
        }
    }
}
