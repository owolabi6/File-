using System;

namespace MediaApp
{
    class Program
    {
        static void Main(string[] args)
        {
          /*Declear an array of months january to december
            1)Return the number of month.
            2)Return the rank of the month.
            3)Reverse the month using loop and array method.
            4)Sort the month in alphabetical order using loop and array method.
            5)Copy the first six months to another array.
            6)Clone the month using array method.
            7)Clear all the months.
            8)Clear months starting from index 6.*/

           // NO 1
          Console.WriteLine("Question1");
           string[] Months = {"JAN","FEB","MAR","APR","MAY","JUN","JUL","AUG","SEPT","OCT","NOV","DEC"};
            int length = Months.Length;
             {
                 Console.WriteLine(length);
             }

             //No 2.
             Console.WriteLine("Question 2"); 
             for(int i=  0; i < Months.Length; i++)
             {
                 Console.WriteLine("Rank[{0}] = {1}", i, Months[i]);
             }

             //No 3.
             Console.WriteLine("Question 3");
             for(int i = Months.Length -1; i >= 0; i--)
             {
                 Console.WriteLine(Months[i]);
             }

             //No 4.
           /*  Console.WriteLine("Question 4");
             Array.Sort(Months);
            foreach(string s in Months)
               Console.WriteLine(s + " "); */

            //5.
            Console.WriteLine("Question 5");
          //   string [] Months = new string [12] {"JAN","FEB","MAR","APR","MAY","JUN","JUL","AUG","SEPT","OCT","NOV","DEC"}; 
             string [] months = new string [6] {"JAN","FEB","MAR","APR","MAY","JUN"};
             for (int i = 0; i < 12; i++)

             Array.Copy(Months, 0, months, 0, 6);
             Console.WriteLine("New Array...");
             foreach (var item in months)
            {
                Console.WriteLine(item);
            }
             

            //6.
            Console.WriteLine("Question 6");
            var target = (string[])Months.Clone();
             foreach(var element in target)
            {
               Console.WriteLine(element);
            }
               Console.ReadLine();

            //7.
             Console.WriteLine("Question 7");
             Console.WriteLine(" All months in array :");
           foreach(string val in Months)
           {
               Console.WriteLine(val);
           }
           Array.Clear(Months, 0, Months.Length);
           Console.WriteLine("All months cleared from the array :");
           foreach (string val in Months)
           {
               Console.WriteLine(val);
           }   

           //8.
          /*for (int i = 0; i<Months.Length;i++) 
           Array.Clear(Months,6,11);
           Console.WriteLine("monts cleard from index 6");
           foreach( string val in Months)
           {
               Console.WriteLine(val);
           }	*/
                
                

        }

    }    
}




        


