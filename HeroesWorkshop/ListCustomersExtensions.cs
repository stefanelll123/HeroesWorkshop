using System.Collections.Generic;

namespace HeroesWorkshop
{
    internal static class ListCustomersExtensions
    {
        public static string PrintCustomersNice(this IList<Customer> customers)
        {
            var result = "Customers: \n";
            foreach (var customer in customers)
            {
                result += $"\t{customer.ToString()}\n";
            }

            return result;
        }
    }
}
