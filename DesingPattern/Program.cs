using DesingPattern.DependencyInjectionPattern;
using DesingPattern.FactoryPattern;
using System;

#region Singleton

///// Ejemplo de Singleton en Logs
//var log = SingletonPattern.Log.Instance;
//log.Save("Aldedier");
//log.Save("Martinez");

//Console.WriteLine(log.Read());

///// Ejemplo de verificacion instancia unica del Singleton
//var singleton = SingletonPattern.Singleton.Instance;
//var a = SingletonPattern.Singleton.Instance;
//var b = SingletonPattern.Singleton.Instance;

//if (a == b)
//    Console.WriteLine("Las instancias son iguales");
//else
//    Console.WriteLine("Las instancias no son iguales");

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

#region Inject Dependency

var beer = new Beer("Poker", "Bavaria");
var drinkWithBeer = new DrinkWithBeer(10, 1, beer);
drinkWithBeer.Build();

#endregion


