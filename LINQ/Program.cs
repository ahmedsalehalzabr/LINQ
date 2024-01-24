// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;

//method عادي

var orderList = GetData.GetCustomers().
            OrderByDescending(x => x.age).
           ThenByDescending (x => x.name) ;
           //OrderBy(x => x.age);

//query methods

var orderList2 = from o in GetData.GetCustomers()
                 orderby o.age descending , o.name
                 select o;
   

foreach ( var order in orderList )
{
    Console.WriteLine("Id: {0}, name:{1}, age: {2}"
        ,order.id, order.name, order.age);
   
}

Console.WriteLine("..........................");
foreach (var order in orderList2)
{
    Console.WriteLine("Id: {0}, name:{1}, age: {2}"
        , order.id, order.name, order.age);

}