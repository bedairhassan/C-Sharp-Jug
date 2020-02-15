using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Jug jug = new Jug(0,5);
            Jug jug2 = new Jug(1,3);
            
            Product.Cases(new Product(jug,jug2));
        }
    }
}
