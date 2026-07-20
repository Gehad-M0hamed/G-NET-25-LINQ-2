namespace G_NET_25_LINQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1:
            //var top3Products = products
            //   .OrderByDescending(p => p.UnitPrice)
            //  .Take(3);
            #endregion

            #region Q2:
            //var page2Products = products
            //   .Skip(5)
            //   .Take(5);
            #endregion

            #region Q3:
            //var products = ProductList
            //   .TakeWhile(p => p.UnitPrice < 25);
            #endregion

            #region Q4:
            //bool allSeafoodInStock = ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .All(p => p.UnitsInStock > 0);
            #endregion

            #region Q5:
            //int[] ids = { 3, 9, 13, 18 };

            //bool containsNine = ids.Contains(9);
            #endregion

            #region Q6:
            //var groups = ProductList
            //   .GroupBy(p => p.Category);

            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"{group.Key} : {group.Count()}");
            //}
            #endregion

            #region Q7:
            //var result = ProductList
            //   .GroupBy(p => p.Category)
            //   .Select(g => new
            //   {
            //      Category = g.Key,
            //      ProductNames = g.Select(p => p.ProductName)
            //   });
            #endregion

            #region Q8:
            //var result = ProductList
            //   .GroupBy(p => p.Category)
            //   .Where(g => g.Count() > 3)
            //   .Select(g => g.Key);
            #endregion

            #region Q9:
            //var result =
            //   from c in CustomerList
            //   group c by c.Country into g
            //   select new
            //   {
            //        Country = g.Key,
            //        Count = g.Count(),
            //        TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //   };
            #endregion

            #region Q10:
            //var totalUnitsInStock = ProductList.Sum(p => p.UnitsInStock);
            #endregion

            #region Q11:
            //decimal cheapestPrice = ProductList.Min(p => p.UnitPrice);
            //decimal mostExpensivePrice = ProductList.Max(p => p.UnitPrice);
            #endregion

            #region Q12:
            //var categories = ProductList
            //    .Select(p => p.Category)
            //    .Distinct();
            #endregion

            #region Q13:
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);
            #endregion

            #region Q14:
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            #endregion

            #region Q15:
            //var productDictionary = ProductList.ToDictionary(p => p.ProductID);

            //Product product = productDictionary[18];

            //Console.WriteLine(product.ProductName);
            #endregion

            #region Q16:
            //var product = ProductList.First(p => p.UnitPrice > 50);
            #endregion

            #region Q17:
            //var product = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            #endregion

            #region Q18:
            //var table = Enumerable.Range(1, 10)
            //    .Select(x => new
            //    {
            //        Number = x,
            //        Result = 7 * x
            //    });
            #endregion















        }
    }
}
