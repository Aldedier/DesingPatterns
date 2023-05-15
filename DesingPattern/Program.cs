using DesingPattern.DependencyInjectionPattern;
using DesingPattern.FactoryPattern;
using DesingPattern.Models;
using DesingPattern.RepositoryPattern;
using DesingPattern.UnitOfWorkPattern;
using System;
using System.Collections.Generic;
using System.Linq;

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

//var beer = new DesingPattern.DependencyInjectionPattern.Beer("Poker", "Bavaria");
//var drinkWithBeer = new DrinkWithBeer(10, 1, beer);
//drinkWithBeer.Build();

#endregion

#region Conectar SQLServer

//using (var context = new DesingPatternsContext())
//{
//    var lst = context.Beers.ToList();

//    foreach (var item in lst) 
//    {
//        Console.WriteLine($"{item.Name} - {item.Style}");
//    }
//}

#endregion

#region Repository

//using (var context = new DesingPatternsContext())
//{
//    var beerRepository = new BeerRepository(context);
//    var beer = new DesingPattern.Models.Beer();
//    beer.Name = "Corona";
//    beer.Style = "Bavaria";
//    beerRepository.Add(beer);
//    beerRepository.Save();

//    foreach (var item in beerRepository.Get())
//    {
//        Console.WriteLine($"{item.Name} - {item.Style}");
//    }
//}


//using (var context = new DesingPatternsContext())
//{
//    var beerRepository = new Repository<DesingPattern.Models.Beer>(context);
//    var beer = new DesingPattern.Models.Beer { Name = "Pokerona", Style = "Bavaria" };
//    beerRepository.Add(beer);
//    //beerRepository.Delete(1);
//    beerRepository.Save();

//    foreach (var item in beerRepository.Get())
//    {
//        Console.WriteLine($"{item.Name} - {item.Style}");
//    }

//    var brandRepository = new Repository<DesingPattern.Models.Brand>(context);
//    var brand = new DesingPattern.Models.Brand { Name = "Agua" };
//    brandRepository.Add(brand);
//    brandRepository.Save();

//    foreach (var item in brandRepository.Get())
//    {
//        Console.WriteLine(item.Name);
//    }
//}

#endregion

#region UnitOfWork

//using (var context = new DesingPatternsContext())
//{
//    var unitOfWork = new UnitOfWork(context);

//    var beers = unitOfWork.Beers;
//    var beer = new DesingPattern.Models.Beer()
//    {
//        Name = "Fuller",
//        Style = "Porter"
//    };

//    beers.Add(beer);

//    var brands = unitOfWork.Brands;
//    var brand = new DesingPattern.Models.Brand()
//    {
//        Name = "Agua",
//    };

//    brands.Add(brand);

//    unitOfWork.Save();

//}

#endregion

Console.WriteLine("");
