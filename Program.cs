using System;
using System.Collections;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Jug jug2 = new Jug(6, 7);
            Jug jug1 = new Jug(3, 10);

            Product initialState = new Product(jug2,jug1);

            ArrayList products = Product.Cases(initialState);
            Product.Display(initialState,products,true,1);

            // products2
            System.Console.WriteLine();
            Product iS2=new Product(new Jug(7,8),new Jug(3,6));
            ArrayList products2=Product.Cases(iS2);
            Product.Display(iS2,products2,true,2);

            System.Console.WriteLine("\nISSUE: HOW TO MAKE IT NESTED?");
        }
    }
}
