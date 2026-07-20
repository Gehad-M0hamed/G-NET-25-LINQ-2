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









        }
    }
}
