using System;
using System.Collections.Generic;
using System.Text;
using static AbstractFactoryFinalCase.Program;
namespace AbstractFactoryFinalCase
{
    public class ConcreteOrderFactory:RetailFactory
    {
        public void MakeElectronics(Channel channel,ProductType product)
        {
            new ElectronicProducts(product, channel);
        }

        public void MakeToys(Channel channel, ProductType product)
        {
            new Toys(product, channel);
        }

        public void MakeFurniture(Channel channel, ProductType product)
        {
            new Furniture(product, channel);
        }
    }
}
