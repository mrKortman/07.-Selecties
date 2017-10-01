using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Selecties
{
    class Program
    {
        /* Dit programma vraagt om een geboortejaar, en laat vervolgens zien of
           er wel of geen alcohol genutigd mag worden aan de hand van een selectie */

        static void Main(string[] args)
        {
            bool blnQuitProgram = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Geef uw geboortejaar op : ");
                double dblDateOfBirtrh = Convert.ToDouble(Console.ReadLine());
                
                // IF / ELSE STATEMENT (SELECTIE)
                if ((dblDateOfBirtrh + 18) >= 2017)
                {
                    Console.WriteLine("Helaas u bent nog geen 18 jaar en mag nog geen alcohol nuttigen!");
                }
                else
                {
                    Console.WriteLine("U bent ouder dan 18 jaar en mag alcohol nuttigen, veel plezier!");
                }

                Console.WriteLine("Wilt u nog een leeftijd checken ? (j/n)");

                string strContinue = Console.ReadLine();

                // IF STATEMENT (SELECTIE)
                if (strContinue == "n")
                {
                    blnQuitProgram = true;
                }
            }
            while (!blnQuitProgram);
        }
    }
}