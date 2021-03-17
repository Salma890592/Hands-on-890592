using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP_Hands_On2
{
    public class ProducerFactory
    {
        public static AbstractFactory GetFactory(string type)
        {
            switch (type)
            {
                case "Mercedes":
                    return new MercedesFactory();
                case "Audi":
                    return new AudiFactory();
                default:
                    throw new ApplicationException($"{type} Car type is invalid");
            }
        }
    }
}
