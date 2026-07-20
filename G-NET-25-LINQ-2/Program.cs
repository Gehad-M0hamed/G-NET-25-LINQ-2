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









        }
    }
}
