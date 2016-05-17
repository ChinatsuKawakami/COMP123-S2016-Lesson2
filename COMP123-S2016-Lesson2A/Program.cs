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
 *Versiton : 0.0.3 - Added andXandY method and associated test
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
    }
}
