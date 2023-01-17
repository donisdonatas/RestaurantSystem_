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

            //Task_1();
            //Task_1_Draw();
            Task_2();
        }

        static void Task_1()
        {
            //Užduotis Nr. 1
            Console.WriteLine("Užduotis Nr. 1");
            Console.WriteLine("- Į konsolę išvedamas mano vardas: {0}", "Donatas");
            Console.WriteLine("- Dabar reikia įrašyti savo vardą ir konsolė jį turi atkartoti:");
            string myName = Console.ReadLine();
            Console.WriteLine("Tu parašei, kad tavo vardas yra: {0}", myName);
            char[] firstLetter = myName.ToCharArray();
            Console.WriteLine("Mano vardo pirma raidė yra: {0}", firstLetter[0]);
            int ascii = (int)firstLetter[0];
            Console.WriteLine("Vardo pirmos raidės ASCII kodas yra: {0}", ascii);
            Console.WriteLine("Įrašykite skaičių:");
            int skaicius = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Pirmos vardo raidės ASCII kodo ir įvesto skaičiaus suma: {0} + {1} = {2}", ascii, skaicius, ascii + skaicius);

            Console.WriteLine("Meniu punktai: \n (1) Pirkti \n (2) Parduoti \n (3) Likučiai");
            Console.WriteLine("Pasirinkite punktą iš pateikto meniu:");
            int meniu = Int32.Parse(Console.ReadLine());
            switch (meniu)
            {
                case 1:
                    Console.WriteLine("Pasirinktas punktas: Pirkti");
                    break;
                case 2:
                    Console.WriteLine("Pasirinktas punktas: Parduoti");
                    break;
                case 3:
                    Console.WriteLine("Pasirinktas punktas: Likučiai");
                    break;
                default:
                    Console.WriteLine("Įvestas blogas kodas.");
                    break;
            }
            Console.WriteLine("=====================================");
            Console.ReadLine();

            //Užduotis Nr. 2
            Console.WriteLine("Užduotis Nr. 2");
            Console.WriteLine("Žodžio LABAS raidžių išskaidymas į atskiras eilutes");
            string labas = "LABAS";
            char[] raides = labas.ToCharArray();
            foreach (char raide in raides)
            {
                Console.WriteLine("{0}", raide);
            }
            Console.WriteLine("Žodžio LABAS raidžių išplėtimas su tabu");
            foreach (char raide in raides)
            {
                Console.Write("{0}\t", raide);
            }
            Console.WriteLine();
            Console.WriteLine("Žodžio LABAS išvedimas su Escape kabutėmis: \"{0}\"", labas);
            Console.WriteLine("Žodžio LABAS išvedimas su HEX kabutėmis: \x0022{0}\x0022", labas);
            Console.WriteLine("=====================================");
            Console.ReadLine();


            //Užduotis Nr. 2 (2)
            Console.WriteLine("Užduotis Nr. 2 (2)");
            Console.WriteLine("Mano vardo antra raidė: {0}", firstLetter[1]);
            Console.WriteLine("Mano vardo ilgis: {0}", firstLetter.Length);
            Console.WriteLine("|\t{0}|\t{1}|", myName, firstLetter.Length);
            Console.WriteLine("Mano vardas trimis eilutėmis žemiau:\n\n\n{0}", myName);
            Console.WriteLine("=====================================");
            Console.ReadLine();


            //Užduotis Nr. 4
            Console.WriteLine("Užduotis Nr. 4");
            Console.WriteLine("Dabar reikia įrašyti skaičių:");
            string sk1 = Console.ReadLine();
            Console.WriteLine("Ir dar reikia įrašyti vieną skaičių:");
            string sk2 = Console.ReadLine();
            int nulis = (int)"0".ToCharArray()[0];
            int ascii1 = (int)sk1.ToCharArray()[0];
            int ascii2 = (int)sk2.ToCharArray()[0];
            Console.WriteLine("ASCII 1: {0}", ascii1);
            Console.WriteLine("ASCII 2: {0}", ascii2);
            Console.WriteLine("Skaičių suma: {0} + {1} = {2}", sk1, sk2, (ascii1 - nulis) + (ascii2 - nulis));
            Console.WriteLine("=====================================");
            Console.ReadLine();
        }

        static void Task_1_Draw()
        {
            Console.WriteLine("\t         ****************");
            Console.WriteLine("\t      **                  **");
            Console.WriteLine("\t     **     ()      ()     **");
            Console.WriteLine("\t    **          |           **");
            Console.WriteLine("\t   **           |            **");
            Console.WriteLine("\t    **    *     |     *     **");
            Console.WriteLine("\t     **    *         *     **");
            Console.WriteLine("\t      **     * * * *      **");
            Console.WriteLine("\t       **                **");
            Console.WriteLine("\t        ****************");


            Console.WriteLine("=====================================");
            Console.ReadLine();
        }
        static void Task_2()
        {
            Console.WriteLine("Kintamieji");
            Console.WriteLine("=====================================");
            Console.WriteLine("Užduotis Nr. 1");
            Console.WriteLine("Įveskite du skaičius:");
            Console.WriteLine("Pirmas skaičius:");
            int sk1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Antras skaičius:");
            int sk2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skaičių suma: {0} + {1} = {2}", sk1, sk2, sk1 + sk2);
            Console.WriteLine("Skaičių skirtumas: {0} - {1} = {2}", sk1, sk2, sk1 - sk2);
            Console.WriteLine("Skaičių daugyba: {0} * {1} = {2}", sk1, sk2, sk1 * sk2);
            Console.WriteLine("Skaičių dalyba: {0} / {1} = {2}", sk1, sk2, Convert.ToDouble(sk1) / Convert.ToDouble(sk2));
            Console.WriteLine("=====================================");

            Console.WriteLine("Užduotis Nr. 2");
            Console.WriteLine("Įveskite tris skaičius:");
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Įveskite tris skaičius {0}/3:", i + 1);
                int sk = int.Parse(Console.ReadLine());
                arr[i] = sk;
            }
            double avg = arr.Average();
            Console.WriteLine("Įvestų skaičių vidurkis: {0}", avg);
            Console.WriteLine("=====================================");

            Console.WriteLine("Užduotis Nr. 3");
            string scool = "CodeAcademy";
            string @class = "Vigi45";
            int students = 16;
            string today = DateTime.Today.ToString("yyyy.MM.dd");
            Console.WriteLine($"Mokykla {scool}");
            Console.WriteLine($"Klasė {@class}");
            Console.WriteLine($"Studentų skaičius {students}");
            Console.WriteLine($"Šiandienos data {today}");
            Console.WriteLine("=====================================");

            Console.WriteLine("Užduotis Nr. 4");
            DateTime start = new DateTime(2022, 07, 28);
            DateTime finish = new DateTime(2023, 04, 28);
            TimeSpan deltaDays = finish - start;
            int weeks = (int)deltaDays.TotalDays / 7;
            int wDays = weeks * 4;
            Console.WriteLine("Dienų skaičius tarp datų: {0}", (int)deltaDays.TotalDays);
            Console.WriteLine("Tai sudaro {0} savaites", weeks);
            Console.WriteLine("Viso pamokų dienų: {0}", wDays);
            Console.ReadLine();
        }

    }
}
