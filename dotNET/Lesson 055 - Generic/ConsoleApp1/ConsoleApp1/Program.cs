using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Validation<String> validation = new Validation<String>();
            validation.Validate("notNull");

            var showValues = new ShowValues<string, bool>();
            showValues.Print("Žodis", true);


            var MyList = new MySelfMadeList<string>();
            MyList.AddElement("Žodis");
            MyList.AddElement("Kitas žodis");
            MyList.AddElement("Dar vienas sakinys");
            MyList.Print();


            MyList.DeleteElement("Kitas žodis");

            MyList.Print();
            /*
            foreach(var item in MyList)
            {
                Console.WriteLine(item);
            }
            */

            Console.WriteLine("=========================");
            //===================
            // Failas Nr.2
            // Užduotis: 1
            // Method
            //===================
            var newMethod = new Method<int, string>(1, "string");
            newMethod.PrintT1();
            newMethod.PrintT2();
            newMethod.ChangeT1Value(2);
            newMethod.ChangeT2Value("word");
            newMethod.PrintT1();
            newMethod.PrintT2();

            Console.WriteLine("=========================");
            Console.WriteLine("Program Nr. 2");
            //===================
            // Failas Nr.2
            // Užduotis: 2
            // FourSideGeometricFigure​
            //=========================
            FourSideGeometricFigure figure = new FourSideGeometricFigure();
            Console.WriteLine(figure.ToString());

            Console.WriteLine("=========================");
            Console.WriteLine("Program Nr. 3");
            //===================
            // Failas Nr.2
            // Užduotis: 3
            // Type​
            //=========================
            var newType = new Type<int, string>();
            newType.param1 = 5;
            newType.GetType(newType.param1);

            Console.WriteLine("=========================");
            //===================
            // Failas Nr.2
            // Užduotis: 4
            // Lygues​
            //=========================
            var ALyga = new Leagues<string>("Krepšinis");
            ALyga.AddTeam("Antys", "Krepšinis");
            ALyga.AddTeam("Asilai", "Krepšinis");
            ALyga.AddTeam("Agurkai", "Krepšinis");

            var BLyga = new Leagues<string>("Futbolas");
            BLyga.AddTeam("Begemotai", "Futbolas");
            BLyga.AddTeam("Banginiai", "Futbolas");
            BLyga.AddTeam("Batatai", "Krepšinis");

            BLyga.PrintAllTeams();

            Console.ReadLine();
        }
    }
}
