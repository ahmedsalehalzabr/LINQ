using SeedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Extension
{
    public static class Filter
    {
        //extension method بحث بالاسم
        public static List<Customer> getByName(this List<Customer> _list, string name)
        {
            List<Customer> ahmeds = new List<Customer>();
            foreach (Customer item in _list)
            {
                if(item.name.ToLower().Contains(name))
                {
                    ahmeds.Add(item);
                }
            }
            return ahmeds;
        }

        //فانك دلقيت برميتر كاستومر يرجع بولين
        public static List<Customer> getCstomer(this List<Customer> _list, Func<Customer, bool> func)
        {
            List<Customer> list = new List<Customer>();
            foreach (Customer item in _list)
            {
                if (func(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }

    }
}
