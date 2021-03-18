using System;

namespace AdapterPatternHandsOn4
{
    class Program
    {
        static void Main(string[] args)
        {
            BugattiVeyron bugattiVeyron = new BugattiVeyron();
            Console.WriteLine(bugattiVeyron.getSpeed());

            MovableAdapter movableAdapter = new MovableAdapterImpl(bugattiVeyron);
            Console.WriteLine(movableAdapter.getSpeed());

            Console.WriteLine(bugattiVeyron.getPrice());

            PriceAdapter priceAdapter = new PriceAdapterUsdToEuro(bugattiVeyron);
            Console.WriteLine(priceAdapter.getPrice());

            Console.ReadLine();
        }
    }
}
