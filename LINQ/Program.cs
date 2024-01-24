// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;



// inner relationshop
//one to miny 
//method
var cats = GetData.GetCategories();
var custs = GetData.GetCustomers();

var result = cats.Join(custs,
             cat => cat.Id, cust => cust.categoryId,
             (cat, cust) => new
             {
                 fullName = cust.name,
                 catName = cat.Name
             });

foreach (var item in result)
    Console.WriteLine(item.fullName + ":" + item.catName);

Console.WriteLine("...........................");

//group left join
var resultl = cats.GroupJoin(custs,
             cat => cat.Id, cust => cust.categoryId,
             (cat, cust) => new
             {
                 myCustomers  = cust,
                 catName = cat.Name
             });

foreach (var item in resultl)
{
    Console.WriteLine("category :" + item.catName);
    if(item.myCustomers != null)
    {
        foreach (var c in item.myCustomers)
            Console.WriteLine("-------->" + c.name);
    }
}

Console.WriteLine("...........................");

//query
var result2 = from cat in cats
              join cust in custs
              on cat.Id equals cust.categoryId
              select new
              {
                  fullName = cust.name,
                  catName = cat.Name,
              };

foreach (var item in result2)
    Console.WriteLine(item.fullName + ":" + item.catName);

//left join wit query
var result2l = from cat in cats
              join cust in custs
              on cat.Id equals cust.categoryId
              into customer
              select new
              {
                  myCustomers = customer,
                  catName = cat.Name,
              };


foreach (var item in result2l)
{
    Console.WriteLine("category :" + item.catName);
if (item.myCustomers != null)
{
    foreach (var c in item.myCustomers)
        Console.WriteLine("-------->" + c.name);
}
}