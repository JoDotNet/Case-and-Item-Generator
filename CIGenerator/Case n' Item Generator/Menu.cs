using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Case_n__Item_Generator
{
    internal class Menu
    {
        string Title = "Case & Item Generator";
        string By = "By: Jo";

        int Choice;

        public void NewMenu()
        {
            Console.Clear();


            Console.WriteLine(Title);
            Console.WriteLine(By);

            Console.WriteLine("---------------------");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("[1] Item Generator");
            Console.WriteLine("[2] Case Maker (unavailable)");
            Console.WriteLine("");

            Console.Write("Your Choice: ");
            Choice = int.Parse(Console.ReadLine());

            ItemGenerator itemG = new ItemGenerator();
            CaseGenerator caseG = new CaseGenerator();

            if (Choice == 1) itemG.StartItemGenerator();
            else if (Choice == 2) caseG.StartCaseGenerator();
            else
            {
                Console.Clear();
                NewMenu();
            }
        }
    }
}
