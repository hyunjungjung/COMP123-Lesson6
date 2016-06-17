using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author : Joanne Jung
 * Date : Jun3 17, 2016
 * Student Number : 300432364
 * Description : The program tests the Player and Enemy Classes
 * Version : 0.0.1 - Initial Test Version - testing basic classes methods
 */

namespace PlayerProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Player greenPlayer = new PlayerProject.Player("green");

            greenPlayer.MoveForward();

            TouchingEnemy redEnemy = new TouchingEnemy("red");

            redEnemy.MoveForward();

            WaitForAnyKey();
        }

        /**
         * <summary>
         * Utility method to wait for a console key press from the user
         * </summary>
         * 
         * @method WaitForAnyKey
         * @return {void}
         */ 
        public static void WaitForAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
