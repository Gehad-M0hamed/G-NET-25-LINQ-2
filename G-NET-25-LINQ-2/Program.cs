namespace G_NET_25_LINQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1:
            var top3Products = products
               .OrderByDescending(p => p.UnitPrice)
              .Take(3);
            #endregion

            #region Q2:
            var page2Products = products
               .Skip(5)
               .Take(5);
            #endregion











        }
    }
}
