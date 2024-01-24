// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;


//يعطيني رقم الاندكس
//var elemnt = GetData.GetCustomers().ElementAt(5);
//اذا القيمة المطلوبة غير موجودة
var elemnt = GetData.GetCustomers().ElementAtOrDefault(500);

if (elemnt != null)
    Console.WriteLine(elemnt.name);
else
    Console.WriteLine("no here");


//2 يعطيك رقم فريد فقط
var single = GetData.GetCustomers().Single(x => x.id == 105);

if (single != null)
    Console.WriteLine(single.name);
else
    Console.WriteLine("no here");

//3
var count = GetData.GetCustomers().Count(x => x.age > 30);

//4
var max = GetData.GetCustomers().Max(x => x.age);
//5
var avrage = GetData.GetCustomers().Average(x => x.spendAverage);
//6
var sum = GetData.GetCustomers().Sum(x => x.spendAverage);