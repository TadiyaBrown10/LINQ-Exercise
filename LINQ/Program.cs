namespace LINQ
{
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> nailPolishcolor = new List<string>();

            nailPolishcolor.Add("Black");
            nailPolishcolor.Add("Gray");
            nailPolishcolor.Add("Red");
            nailPolishcolor.Add("Blue");
            nailPolishcolor.Add("Yellow");

            var inOrder = nailPolishcolor.OrderBy(polish => polish.Length);

            foreach(var name in inOrder)
            {
                Console.WriteLine(name);

            }
        }

        

       

    }
}
