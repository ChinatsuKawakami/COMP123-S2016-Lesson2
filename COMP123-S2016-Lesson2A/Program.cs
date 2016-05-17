using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Author: Chinatsu Kawakami
 *Date: May 17th 2016
 *Date Modified: May 17th 2016
 *Description: Advanced Method Demo for Lesson2
 *Versiton : 0.0.4 - Added readUnitEnd - not completed
 */
namespace COMP123_S2016_Lesson2A
{
    /**
     * Main driver class for Lesson2 
     * 
     * @class Program
     * 
     */
   public class Program
    {
        /**
         * Main Method for our drive class
         * 
         * @constructor Main
         * @pram {string[]} args
         */
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0;
         result = addXandY(x, y);
            Console.WriteLine(result);
            Console.WriteLine();

            addYtoX(ref x, ref y);//pass 50 = +40
            Console.WriteLine(x);
            Console.WriteLine();

            Console.WriteLine(readUntilEnd());
        }

       /**
        * simple Method to add two values
        * 
        * @method addXandY
        * @param {int} firstNumber
        * @param {int} secondNumber
        */
       public static int addXandY(int firstNumber, int SecondNumber)
        {
            int result = 0;
            result = firstNumber + SecondNumber;
            return result;
            

                
        }

       /**
        * simple method to demonstrate pass by reference with ref Keyword
        * 
        * @method addYtoX
        * @param {ref int} X
        * @param {ref int} Y
        * 
        */
       public static int addYtoX(ref int X, ref int Y)
       {
           X += Y;
           return X;
       }
       public static string[] readUntilEnd()
       {
           string[] inputs = new string[50];//never change object
           int inputCounter = 0;
         

           do
           {
               Console.WriteLine("Enter a value -('end' to stop): ");
               inputs[inputCounter] = Console.ReadLine();
               if(inputs[inputCounter]=="end")
               {
                   inputCounter = -1;
               }
               else
               {
                   inputCounter++;
               }
           } while (inputCounter !=-1);
           return inputs;
       }
    }
}
