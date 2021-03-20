using System;
using System.Collections.Generic;
using System.Text;
using static AbstractFactoryFinalCase.Program;

namespace AbstractFactoryFinalCase
{
    public class RetailClient
    {
        RetailFactory retailFactory1;
        public RetailClient(RetailFactory retailFactory)
        {
            retailFactory1 = retailFactory;
        }

        public void BuilderElectronics(Channel channel)
        {
            retailFactory1.MakeElectronics(channel, ProductType.ELECTRONICPRODUCTS);
        }
        public void BuilderToys(Channel channel)
        {
            retailFactory1.MakeToys(channel, ProductType.TOYS);
        }

        public void BuilderFurniture(Channel channel)
        {
            retailFactory1.MakeFurniture(channel, ProductType.FURNITURE);
        }
    }
}
