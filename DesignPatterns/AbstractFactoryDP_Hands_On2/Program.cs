using System;
using AbstractFactoryDP_Hands_On2.AbstractHeadLight;
using AbstractFactoryDP_Hands_On2.AbstractTire;


namespace AbstractFactoryDP_Hands_On2
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Console.WriteLine("Enter car of type Audi or Mercedes");
            string car = Console.ReadLine();
            AbstractFactory factory =ProducerFactory.GetFactory(car);
            ITire tire = factory.makeTire();
            tire.GetTire();
            IHeadLight headlight = factory.makeHeadLight();
            headlight.GetHeadLight();
            Console.ReadLine();
        }
    }
}
