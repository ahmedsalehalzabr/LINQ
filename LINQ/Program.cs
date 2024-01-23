// See https://aka.ms/new-console-template for more information
//using LINQ.Extension;
//using SeedData;
//using SeedData.Models;


//linq => مجموعة من Extension methods تستخدم فانك دلقيت مع لمدا وعددها تقريبا 40

//Extension methods

//Console.WriteLine("Hello, World!");

//var ahmedList = GetData.GetCustomers().getByName("ahmed");

//foreach (var ahmed in ahmedList)
//{
//    Console.WriteLine($"name {ahmed.name} :age {ahmed.age}");
//}


//Anonymous type

//var c1 = new { id = 101, name = "ahmed mohmed", age = 31, };
//var c2 = new { id = 102, name = "ahmed mohmed", age = 31, };
//var c3 = new { id = 101, name = "ahmed mohmed" };
//var c4 = new { id = 101, name = "ahmed mohmed", age = 31, };

//Console.WriteLine(c1.Equals(c4));
//Console.WriteLine(c3.GetType().Name);

//بولين فانكشن
//bool checCustomer (Customer customer)
//{
//    if(customer != null && customer.age > 30 && customer.isActive)
//        return true;
//    else
//        return false;
//}

//var custList = GetData.GetCustomers().getCstomer(checCustomer);
//foreach (var cust in custList)
//{
//    Console.WriteLine($"name {cust.name}, age {cust.age}");
//}

//نختصر البولين فانكشن باستخدام lambda expressions
//var custList = GetData.GetCustomers().getCstomer(a => a.age > 30 && a.isActive);
//foreach (var cust in custList)
//{
//    Console.WriteLine($"name {cust.name}, age {cust.age}");
//}


List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<string> stringList = new List<string>
{ "ahemd saleh", "mohmed ali", "saleh naser"};

//اصل الكويري سنتكس او الميذد سينتكس 
//Enumerable.Where()

//qury sintucs كويري سنتكس
//var result = from l in intList
//             where l > 5
//             select l;

//method ميذود سنتاكس 
var result = intList.Where(l => l > 5);


foreach (var item in result)
{
    Console.WriteLine(item);
}