using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task03
{
    internal class Program
    {
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the library");
        }

        static void PrintBookTitle(string title)
        {
            Console.WriteLine("book title:" + title);
        }

        static void  ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        static void AddBonusPages(int pages)
        {
            pages += 5;
        }

        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 5;
        }

        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

        static bool TryGetPrice(string title, out double price)
        {
            if(title=="clean code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }

            
        }

        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"book: {title}, pages: {pages}");
        }
        static void Main(string[] args)
        {
            #region Question01
            //            Create a one - dimensional array double[] prices with the values 25.5, 40.0, 33.75.Print
            //the second price(index 1).
            //double[] prices = { 2.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Question02
            /*Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.
            */

            //int[,] shelfCopies = { 
            //    { 3, 5},
            //{1, 4 }
            //};
            //Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Question03
            //Write a method called PrintWelcomeMessage that takes no parameters and prints  "Welcome to the Library!".Call it from Main.

            //PrintWelcomeMessage();



            #endregion

            #region Question04
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title.Call it with "Clean Code".

            //PrintBookTitle("Clean code");
            #endregion

            #region Question05
            //            Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?

            //int pages = 400;
            //Console.WriteLine("pages after reward: " + pages);



            //no changes will happen beacause we passed a value type which no changes happen in the address

            #endregion

            #region Question06
            //            Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].Call it
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?

            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine("prices afterward: " + prices[0]);

            #endregion

            #region Question07
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5 ?
            //int pages = 100;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine("pages afterwar: "+pages);

            //with ref changes inside the method affesvt the orriginal variable , without ref method modifies only a coppy
            //so the original variable remains unchanged


            #endregion

            #region question08
            //            Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
            //afterward.

            //double[] prices= { 25.5, 40.0 };

            //ReplaceArray(ref prices);
            //Console.WriteLine("prices after replacing: " + prices.Length);
            #endregion

            #region Question09
            //            Write a method bool TryGetPrice(string title, out double price) that returns true and sets
            //price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it

            //double price;

            //bool result = TryGetPrice("clean code", out price);

            //Console.WriteLine(price);
            //Console.WriteLine(result);


            #endregion

            #region Question10
            //            Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.Call
            //it once with only a title, and once passing both a title and pages.

            //PrintBookInfo("clean code");
            //PrintBookInfo("refacroring", 500);




            #endregion

            #region Question11
            //            Using the PrintBookInfo method from the question above, call it by naming the
            //parameters, passing pages before title

            //PrintBookInfo(pages: 400, title: "refactoeing");


            #endregion

            #region Question12
            //we did not took params object

            #endregion

            

        }
    }
}
