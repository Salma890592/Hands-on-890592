using System;

namespace BuilderPatternDp_Hands_On3
{
    public class Program
    {
        public static void Main()
        {
            ////creating directors and builders
            //Director director = new Director();

            //Builder b1 = new ConcreteBuilder1();
            //Builder b2 = new ConcreteBuilder2();

            ////Construct two products
            //director.Construct(b1);
            //Product p1 = b1.GetResult();
            //p1.Show();

            //director.Construct(b2);
            //Product p2 = b2.GetResult();
            //p2.Show();

            //Console.ReadKey();
            PackageBuilder builder;
            Shop shop = new Shop();

            builder = new ChildBuilder();
            shop.Construct(builder);
            builder.Product.Show();

            builder = new AdultBuilder();
            shop.Construct(builder);
            builder.Product.Show();

            Console.ReadKey();
        }
    }
}
