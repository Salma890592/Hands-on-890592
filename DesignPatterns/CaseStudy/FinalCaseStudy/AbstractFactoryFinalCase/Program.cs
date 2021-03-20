using System;

namespace AbstractFactoryFinalCase
{
    public class Program
    {
        static void Main(string[] args)
        {
            RetailFactory retailFactory = new ConcreteOrderFactory();
            RetailClient retailClient = new RetailClient(retailFactory);

            retailClient.BuilderElectronics(Channel.ECOMMERCEWEBSITE);
            retailClient.BuilderToys(Channel.ECOMMERCEWEBSITE);
            retailClient.BuilderFurniture(Channel.TELECALLERAGENTSAPPLICATION);

            Console.ReadKey();
        }
        public enum ProductType
        {
            ELECTRONICPRODUCTS, TOYS, FURNITURE
        }
        public enum Channel
        {
            ECOMMERCEWEBSITE, TELECALLERAGENTSAPPLICATION
        }

        public abstract class Order
        {
            public Order(ProductType product,Channel channel)
            {
                this.product = product;
                this.channel = channel;
            }

           public abstract void ProcessOrder();


            public ProductType product { get; set; }
            public Channel channel { get; set; }


            public override string ToString()
            {
                return "ProductType - " + product.ToString() + "  accepted by  " + channel.ToString();
                
            }
        }

        public class ElectronicProducts : Order
        {
            public ElectronicProducts(ProductType product, Channel channel) : base(ProductType.ELECTRONICPRODUCTS, channel)
            {
                ProcessOrder();
            }
            public override void ProcessOrder()
            {
                Console.WriteLine("The ordered product is ElectronicProduct");
                Console.WriteLine(base.ToString());
            }
        }


        public class Toys : Order
        {
            public Toys(ProductType product, Channel channel) : base(ProductType.TOYS, channel)
            {
                ProcessOrder();
            }
            public override void ProcessOrder()
            {
                Console.WriteLine("The ordered product is Toys");
                Console.WriteLine(base.ToString());
            }
        }


        public class Furniture : Order
        {
            public Furniture(ProductType product, Channel channel) : base(ProductType.FURNITURE, channel)
            {
                ProcessOrder();
            }
            public override void ProcessOrder()
            {
                Console.WriteLine("The ordered product is Furniture");
                Console.WriteLine(base.ToString());
            }
        }
    }
}
