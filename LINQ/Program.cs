// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;

//method عادي

var customers = GetData.GetCustomers().Where((x, i) => x.age > 30 && i >= 2).Select(
    a => new DtoCustomer
    {
        customerName = a.name,
        customerPhone = a.telephone,
    }
    );
//query methods

var customers2 = from cust in GetData.GetCustomers()
                 where cust.age > 30
                 select new
                 {
                   cust.name,
                   cust.telephone,
                 };
   

foreach ( var customer in customers )
{
    Console.WriteLine(customer.customerName);
    Console.WriteLine(customer.customerPhone);
}
