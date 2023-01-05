using DesingPattern.FactoryPattern;
using System;

namespace DesingPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// No
            #region Singleton
            //var singleton = Singleton.Singleton.Instance;
            //var log = Singleton.Log.Instance;
            //log.Save("Aldedier");
            //log.Save("Martinez");

            //var a = Singleton.Singleton.Instance;
            //var b = Singleton.Singleton.Instance;

            //if (a == b)
            //    Console.WriteLine("Hello World!");
            //else
            //    Console.WriteLine("No se parecen");

            //Console.ReadLine(); 
            #endregion

            #region Factory

            //SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            //SaleFactory internetSaleFactory = new InternetSaleFactory(10);

            //ISale sale1 = storeSaleFactory.GetSale();
            //sale1.Sell(15);

            //ISale sale2 = internetSaleFactory.GetSale();
            //sale2.Sell(15);

            #endregion


        }
    }
}
