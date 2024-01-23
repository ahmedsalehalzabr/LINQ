// See https://aka.ms/new-console-template for more information



List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<string> stringList = new List<string>
{ "ahemd saleh", "mohmed ali", "saleh ahmed"};

var names = stringList.Where(x => x.Contains("ahmed"));

stringList.Remove("ahmed saleh");
stringList.AddRange(new string[] {"ali ahmed", "ahmed zabr ", "zabr"});

foreach (var name in names)
{
    Console.WriteLine(name);
}
//اصل الكويري سنتكس او الميذد سينتكس 
//Enumerable.Where()

//qury sintucs كويري سنتكس
//var result = from l in intList
//             where l > 5
//             select l;

//method ميذود سنتاكس 
//var result = intList.Where(l => l > 5);


//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}