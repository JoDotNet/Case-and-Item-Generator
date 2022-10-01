using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Case_n__Item_Generator
{
    internal class ItemGenerator
    {
        FileStream stream = null;

        public void StartItemGenerator()
        {
            string Name = "";
            string Price = "";
            string ID = "";

            Console.Clear();

            Console.Write("Name of Item: ");
            Name = Console.ReadLine();

            Console.Write("Price of Item: ");
            Price = Console.ReadLine();

            Console.Write("ID of Item: ");
            ID = Console.ReadLine();

            var myUniqueFileName = $@"{DateTime.Now.Ticks}.txt";

            stream = new FileStream(myUniqueFileName, FileMode.OpenOrCreate);

            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                writer.WriteLine($"['{Name}'] = {{");
                writer.WriteLine($" ['Name'] = '{Name}',");
                writer.WriteLine($" ['Price'] = {Price},");
                writer.WriteLine($" ['ID'] = {ID}");
                writer.WriteLine("}");
                writer.Close();
            }
            File.Move(myUniqueFileName, Name+".txt");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Sucesfully created Item, returning...");
            Thread.Sleep(1000);
            Menu menu = new Menu();
            menu.NewMenu();
        }
    }
}
