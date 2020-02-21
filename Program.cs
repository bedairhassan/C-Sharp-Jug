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
            Product.Display(initialState,products,true);
        }
    }
}
