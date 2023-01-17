using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciklai Part 1
            //ciklas11();
            //ciklas12();
            //ciklas13();
            //ciklas14();

            //Ciklai Part 2
            //ciklas21();
            //ciklas22();
            //ciklas23();
            //ciklas24();

            //Kolekcijos Part 1
            //masyvas11();
            //masyvas12();
            //masyvas13();
            //masyvas14();
            //masyvas15();
            //masyvas16();
            //masyvas17();
            //masyvas18();
            //masyvas19();
            //masyvas20();

            //Kolekcijos Part 2
            //masyvas21();
            //masyvas22();
            //masyvas23();
            masyvas24();


            Console.ReadLine();
        }

        static void ciklas11()
        {
            Console.WriteLine("Užduotis Nr. 1");
            Console.WriteLine("Įveskite skaičių. Bus susumuotos reikšmės nuo 1 iki įvesto skaičiaus:");
            int skaicius = int.Parse(Console.ReadLine());
            int suma = 0;
            for(int i = 1; i <= skaicius; i++)
            {
                suma+= i;
            }
            Console.WriteLine("Gaunta suma: {0}", suma);

        }

        static void ciklas12()
        {
            Console.WriteLine("Užduotis Nr. 2");
            Console.WriteLine("Įveskite bet kokį teigiamą skaičių. Bus parodyti visi lyginiai skaičiai nuo 0 iki įvesto skačiaus:");
            int skaicius = int.Parse(Console.ReadLine());
            string lyginiai = "";
            for(int i = 0; i <= skaicius; i++)
            {
                if(i % 2 == 0)
                {
                    lyginiai+= i + "," ;
                }
            }
            string result = lyginiai.Remove(lyginiai.Length - 1);
            Console.WriteLine(result);
        }

        static void ciklas13()
        {
            Console.WriteLine("Užduotis Nr. 3");
            Console.WriteLine("Parašykite sąkinį. Programa parašys sakinį iš kitos pusės:");
            string sakinys = Console.ReadLine();
            string atvirksciai = "";
            char[] raides = sakinys.ToCharArray();
            for(int i = raides.Length - 1;  i >= 0; i--)
            {
                atvirksciai += raides[i];
            }
            Console.WriteLine(atvirksciai);
        }

        static void ciklas14()
        {
            Console.WriteLine("Užduotis Nr. 4");
            
            for(;;)
            {
                Console.WriteLine("Įveskite skaičių. Programa sudarys skaičiaus daugybos lentelę:");
                int skaicius = int.Parse(Console.ReadLine());
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", skaicius, i, skaicius*i);
                }
                Console.WriteLine("Ar norite tęsti: T/N");
                string testi = Console.ReadLine();

                if(testi.ToLower() == "t")
                {
                    //Tęsiam ciklą
                }
                else
                {
                    break;
                }
            }
        }

        static void ciklas21()
        {
            Console.WriteLine("Užduotis Nr. 1");
            Console.WriteLine("Įveskite didelį skaičių. Bus susumuotos reikšmės nuo 1 iki įvesto skaičiaus:");
            double skaicius = double.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i <= skaicius; i++)
            {
                Thread.Sleep(100);
                Console.Write("|");
                suma += i;
            }
            Console.WriteLine();
            Console.WriteLine("Gaunta suma: {0}", suma);
        }

        static void ciklas22()
        {
            Console.WriteLine("Užduotis Nr. 2");
            Console.WriteLine("Įveskite skaičių. Bus nupiešta piramidė iš įvesto skaičiaus eilučių kiekio:");
            int eilutes = int.Parse(Console.ReadLine());
            for(int i = 1; i <= eilutes; i++)
            {
                int j = i;
                while(eilutes - j > 0)
                {
                    Console.Write(" ");
                    j++;
                }
                int k = i;
                while(k > 0)
                {
                    Console.Write("* ");
                    k--;
                }
                Console.WriteLine();
            }
        }

        static void ciklas23()
        {
            Console.WriteLine("Užduotis Nr. 3");
            Console.WriteLine("Parašykite sakinį. Programa parašys sakinio žodžius iš kito galo:");
            string sakinys = Console.ReadLine();
            string[] zodziai = sakinys.Split(' ');
            string atvirksciai = "";
            for (int i = zodziai.Length - 1; i >= 0; i--)
            {
                atvirksciai += zodziai[i] + ' ';
            }
            Console.WriteLine(atvirksciai);
        }

        static void ciklas24()
        {
            Console.WriteLine("Užduotis Nr. 4");
            
            for(;;)
            {
                Console.WriteLine("Įveskite du skaičius ir aritmetinio veiksmo ženklą:");
                Console.WriteLine("Pirmas skaičius:");
                int skaicius1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Antras skaičius:");
                int skaicius2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Aritmetinis ženklas (/, *, -, +):");
                char zenklas = char.Parse(Console.ReadLine());
                switch(zenklas)
                {
                    case '/': Console.WriteLine("{0} / {1} = {2}", skaicius1, skaicius2, ((float)skaicius1 / (float)skaicius2));
                        break;
                    case '*': Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, (skaicius1 * skaicius2));
                        break;
                    case '-': Console.WriteLine("{0} - {1} = {2}", skaicius1, skaicius2, (skaicius1 - skaicius2));
                        break;
                    case '+': Console.WriteLine("{0} + {1} = {2}", skaicius1, skaicius2, (skaicius1 + skaicius2));
                        break;
                    default: Console.WriteLine("Įvesti blogi parametrai");
                        break;
                }
                
                Console.WriteLine("Ar norite tęsti: T/N");
                string testi = Console.ReadLine();

                if (testi.ToLower() == "t")
                {
                    //Tęsiam ciklą
                }
                else
                {
                    break;
                }
            }
        }

        static void masyvas11()
        {
            Console.WriteLine("Užduotis Nr. 1");
            Console.WriteLine("Įveskite 5 skaičius. Programa išves atvirkštine tvarka:");
            int[] skaiciai = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Įveskite skaičių nr. {0}", i + 1);
                skaiciai[i] = int.Parse(Console.ReadLine());
            }
            for(int j = 4; j >= 0; j--)
            {
                Console.Write("{0}, ", skaiciai[j]);
            }
        }

        static void masyvas12()
        {
            Console.WriteLine("Užduotis Nr. 2");
            Console.WriteLine("Įveskite 5 skaičius. Programa išves šių skaičių sumą:");
            int[] skaiciai = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Įveskite skaičių nr. {0}", i + 1);
                skaiciai[i] = int.Parse(Console.ReadLine());
            }
            int suma = 0;
            foreach(int skaicius in skaiciai)
            {
                suma += skaicius;
            }
            Console.WriteLine("Skaičių suma yra: {0}", suma);
        }

        static void masyvas13()
        {
            Console.WriteLine("Užduotis Nr. 3");
            Console.WriteLine("Įveskite 5 skaičius:");
            int[] skaiciai = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Įveskite skaičių nr. {0}", i + 1);
                skaiciai[i] = int.Parse(Console.ReadLine());
            }
            int[] kopija = skaiciai;
            
            Console.WriteLine("Masyvo kopija:");
            foreach (int cSkaicius in kopija)
            {
                Console.Write("{0}, ", cSkaicius);
            }
        }

        static void masyvas14()
        {
            Console.WriteLine("Užduotis Nr. 4");
            Console.WriteLine("Įveskite masyvo dydį, jis bus užpildytas atsitiktiniais skaičiais nuo 1 iki 100:");
            int dydis = int.Parse(Console.ReadLine());
            int[] skaiciai = new int[dydis];
            Random random = new Random();
            
            for(int i = 0; i < dydis; i++)
            {
                skaiciai[i] = random.Next(1, 100);
            }
            Array.Sort(skaiciai);
            foreach(int skaicius in skaiciai)
            {
                Console.Write("{0}, ", skaicius);
            }
            Console.WriteLine();
            Console.WriteLine("Min reikšmė: {0}", skaiciai[0]);
            Console.WriteLine("Max reikšmė: {0}", skaiciai[dydis - 1]);
        }
        static void masyvas15()
        {
            Console.WriteLine("Užduotis Nr. 5");
            Console.WriteLine("Reikia sukurti du masyvus. Kuriuos programa sujungs į vieną ir parodys:");
            Console.WriteLine("Masyvai bus užpildytis atsitiktiniais skaičiais nuo 1 iki 100.");
        
            Console.WriteLine("Įveskite pirmo masyvo dydį:");
            int dydis1 = int.Parse(Console.ReadLine());
            int[] masyvas1 = new int[dydis1];
        
            Console.WriteLine("Įveskite pirmo masyvo dydį:");
            int dydis2 = int.Parse(Console.ReadLine());
            int[] masyvas2 = new int[dydis2];

            int dydis3 = dydis1 + dydis2;
            int[] masyvas3 = new int[dydis3];

            Random random = new Random();
            for (int i = 0; i < dydis1; i++)
            {
                masyvas1[i] = random.Next(1, 100);
                masyvas3[i] = masyvas1[i];
            }
            for (int i = 0; i < dydis2; i++)
            {
                masyvas2[i] = random.Next(1, 100);
                masyvas3[dydis1 + i] = masyvas2[i];
            }
            foreach(int skaicius in masyvas3)
            {
                Console.Write("{0}, ", skaicius);
            }
            Console.WriteLine();

        }

        static void masyvas16()
        {
            Console.WriteLine("Užduotis Nr. 6");
            Console.WriteLine("Sukurkite masyvą įrašydami jo dydį. Bus sukurtas masyvas su atsitiktiniais skaičiais nuo 1 iki 5 ir parodyta, kiek kartojasi tas skaicius?");

            Console.WriteLine("Įveskite masyvo dydį:");
            int dydis = int.Parse(Console.ReadLine());
            int[] masyvas = new int[dydis];
            Random random = new Random();
            for (int i = 0; i < dydis; i++)
            {
                masyvas[i] = random.Next(1, 5);
            }
            //Array.Sort(masyvas);  //nebūtinas
            int[] pasikartojimai = new int[5];
            foreach(int skaicius in masyvas)
            {
                pasikartojimai[skaicius - 1]++;
                Console.Write("{0}, ", skaicius);
            }
            Console.WriteLine();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Skaičius: {0} pasikartoja {1} kartų.", i + 1, pasikartojimai[i]);
            }
        }

        static void masyvas17()
        {
            Console.WriteLine("Užduotis Nr. 7");
            Console.WriteLine("Nurodyk, kokį masyvo narį ištrinti iš 10:");
            int del = int.Parse(Console.ReadLine());
            int[] masyvas = new int[10] 
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] delMasyvas = new int[9];
            int delInx = 0;
            for(int i = 0; i < masyvas.Length; i++)
            {   
                if(i + 1 != del)
                {
                    delMasyvas[delInx] = masyvas[i];
                    delInx++;
                }
                
            }
            foreach(int narys in delMasyvas)
            {
                Console.Write("{0}, ", narys);
            }
        }

        static void masyvas18()
        {
            Console.WriteLine("Užduotis Nr. 8");
            Console.WriteLine("Sukurimas masyvas iš atsitiktinių narių, ir bus išvestas antras didžiausias ir antras mažiausias narys.");
            Console.WriteLine("Įveskite skaičių iš kiek narių turi susidaryti masyvas:");
            int lenght = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];
            Random random = new Random();
            for (int i = 0; i < lenght; i++)
            {
                array[i] = random.Next(1, 100);
            }
            Array.Sort(array);
            foreach (int narys in array)
            {
                Console.Write("{0}, ", narys);
            }
            Console.WriteLine();
            Console.WriteLine("Antras mažiausias narys yra: {0}", array[1]);
            Console.WriteLine("Antras didžiausias narys yra: {0}", array[lenght - 2]);
        }

        static void masyvas19()
        {
            Console.WriteLine("Užduotis Nr. 9");
            Console.WriteLine("Sukurti matricą 3x3 ir išvesti masyvo narių sumą, eilučių sumą ir stulpelių sumą");
            int[,] matrica = new int[3, 3]
            {
                {0, 1, 2},
                {1, 2, 3},
                {2, 3, 4},
            };
            int mSuma = 0;
            for(int i = 0; i < matrica.GetUpperBound(0) + 1; i++)
            {
                int eSuma = 0;
                for (int j = 0; j < matrica.GetUpperBound(1) + 1; j++)
                {
                    eSuma += matrica[i, j];
                    //Console.Write("{0}, ", matrica[i, j]);
                }
                mSuma += eSuma;
                Console.WriteLine("Matricos {0} eilutės suma: {1}", i + 1, eSuma);
                //Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Matricos narių suma: {0}", mSuma);
        }

        static void masyvas20()
        {
            Console.WriteLine("Užduotis Nr. 10");
            Console.WriteLine("Sukurti masyvą iš atsitiktinių skaičių ir jį surušiuoti.");
            Console.WriteLine("Įveskite skaičių iš kiek turi būti sudaryta matrica:");
            int lenght = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];
            Random random = new Random();
            for (int i = 0; i < lenght; i++)
            {
                array[i] = random.Next(1, 100);
            }
            foreach (int narys in array)
            {
                Console.Write("{0}, ", narys);
            }
            Console.WriteLine();
            Console.WriteLine("O čia surūšiuotas Array:");
            for (int j = 0; j < lenght; j++)
            {
                for (int i = 0; i < lenght - 1; i++)
                {
                    int a = array[i];
                    int b = array[i + 1];

                    if (a > b)
                    {
                        array[i + 1] = a;
                        array[i] = b;
                    }
                }
            }
            
            foreach (int narys in array)
            {
                Console.Write("{0}, ", narys);
            }
        }

        static void masyvas21()
        {
            Console.WriteLine("Užduotis Nr. 1");
            Console.WriteLine("Sudaryti sąrašo masyvą ir išvesti visus lyginius skaičius");
            Console.WriteLine("Įrašykite sąrašo dydį:");
            int lenght = int.Parse(Console.ReadLine());
            List<int> array = new List<int>();
            Random random = new Random();
            for (int i = 0; i < lenght; i++)
            {
                array.Add(random.Next(1, 100));
            }
            Console.WriteLine("Sudaryto sąrašo lyginiai nariai:");
            foreach(int narys in array)
            {
                if(narys % 2 == 0)
                {
                    Console.Write("{0}, ", narys);
                }
            }
            
        }

        static void masyvas22()
        {
            Console.WriteLine("Užduotis Nr. 2");
            Console.WriteLine("Sudaryti studentų sąrašą vedant po vieną pavardę į eilutę");
            List<string> regularList = new List<string>(); 
            for(;;)
            {
                Console.WriteLine("Įveskite studeno pavardę:");
                string studentas = Console.ReadLine();
                regularList.Add(studentas);
                
                Console.WriteLine("Ar norite tęsti: T/N");
                string testi = Console.ReadLine();
                if (testi.ToLower() == "n")
                {
                    break;
                }
            }

            List<string> delayList = new List<string>();
            for (; ; )
            {
                Console.WriteLine("Įveskite pavėlavusio studeno pavardę:");
                string studentas = Console.ReadLine();
                delayList.Add(studentas);

                Console.WriteLine("Ar norite tęsti: T/N");
                string testi = Console.ReadLine();
                if (testi.ToLower() == "n") 
                { 
                    break; 
                }
            }

            List<string> combinedList = new List<string>();
            combinedList.AddRange(regularList);
            combinedList.AddRange(delayList);
            combinedList.Sort();
            Console.WriteLine("Pilnas studentų sąrašas");
            foreach(string s in combinedList)
            {
                Console.WriteLine(s);
            }

        }

        static void masyvas23()
        {
            Console.WriteLine("Užduotis Nr. 3");
            Console.WriteLine("Sukurti vardų sąrašą. Viso ~5 vardus:");
            List<string> nameList = new List<string>();
            for (;;)
            {
                Console.WriteLine("Įveskite asmens vardą:");
                string vardas = Console.ReadLine();
                nameList.Add(vardas);

                Console.WriteLine("Ar norite tęsti: T/N");
                string testi = Console.ReadLine();
                if (testi.ToLower() == "n")
                {
                    break;
                }
            }
            Console.ReadLine();
            Console.WriteLine("Sukurtas sąrašas bus papildytas dviem vardais `Nampoleonas` ir `Asterisas`");
            nameList.Add("Napoleonas");
            nameList.Add("Asterisas");
            foreach (string s in nameList)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Iš sąrašo išbraukiamas trečias vardas:");
            nameList.Remove(nameList[2]);
            foreach (string s in nameList)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Vietoje `Napoleono` įrašoma `Kleopatra`:");
            int napoleonas = nameList.IndexOf("Napoleonas");
            nameList[napoleonas] = "Kleopatra";
            foreach (string s in nameList)
            {
                Console.WriteLine(s);
            }
        }

        static void masyvas24()
        {
            Console.WriteLine("Užduotis Nr. 3");
            Console.WriteLine("Pažymių knygelė:");

            IDictionary<string, int> pazymke = new Dictionary<string, int>()
            {
                {"Lietuvių", 7},
                {"Matematika", 8},
                {"Informatika", 10},
                {"Geografija", 6},
                {"Anglų", 5}
            };

            IDictionary<int, string> meniu = new Dictionary<int, string>()
            {
                {0, "papildyti"},
                {1, "Ištrinti"},
                {2, "Įterpti"},
                {3, "Parodyti pažymių vidurkį"},
                {4, "Išeiti iš programos"}
            };

            masyvas24_writePazymke(pazymke);
            Console.WriteLine();
            foreach (KeyValuePair<int, string> pasirinkimas in meniu)
            {
                Console.WriteLine("{0} - {1}", pasirinkimas.Key, pasirinkimas.Value);
            }
            for(;;)
            {
                Console.WriteLine("Pasirinkite punktą iš meniu:");
                int punktas = int.Parse(Console.ReadLine());
                switch(punktas)
                {
                    case 0: 
                        Console.WriteLine("Įveskite pamokos pavadinimą:");
                        string pamokosPav = Console.ReadLine();
                        Console.WriteLine("Įveskite pažymį:");
                        int pazimys = int.Parse(Console.ReadLine());
                        pazymke.Add(pamokosPav, pazimys);
                        masyvas24_writePazymke(pazymke);
                        break;
                    case 1: 
                        Console.WriteLine("Pasirinkite kokią pamoką norite ištrinti:");
                        List<string> pamokuSaras = new List<string>();
                        pamokuSaras.AddRange(pazymke.Keys.ToList());
                        foreach (KeyValuePair<string, int> pamoka in pazymke)
                        {
                            Console.WriteLine("{0}: {1} - {2}", pamokuSaras.IndexOf(pamoka.Key), pamoka.Key, pamoka.Value);
                        }
                        int trinti = int.Parse(Console.ReadLine());
                        pazymke.Remove(pamokuSaras[trinti]);
                        masyvas24_writePazymke(pazymke);
                        break;
                    case 2: 
                        Console.WriteLine("Įterpti pažymį:");
                        Console.WriteLine("Įveskite pamokos pavadinimą:");
                        string pamokosPav2 = Console.ReadLine();
                        Console.WriteLine("Įveskite pažymį:");
                        int pazimys2 = int.Parse(Console.ReadLine());
                        pazymke.Add(pamokosPav2, pazimys2);
                        masyvas24_writePazymke(pazymke);
                        break;
                    case 3: 
                        Console.WriteLine("Parodyti pažymių vidurkį");
                        int suma = 0;
                        foreach (KeyValuePair<string, int> pamoka in pazymke)
                        {
                            suma += pamoka.Value;
                        }
                        float vidurkis = (float)suma / (float)pazymke.Count;
                        Console.WriteLine("Pažymių vidurkis: {0}", vidurkis);
                        break; 
                    case 4: 
                        Console.WriteLine("Išeiti iš programos");
                        Console.WriteLine("Ar norite išeiti iš progrtamos? T/N");
                        string iseiti = Console.ReadLine();
                        if (iseiti.ToLower() == "t")
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default: Console.WriteLine("Blogai įvestas punktas.");
                        break;
                }
            }
        }

        static void masyvas24_writePazymke(IDictionary<string, int> pazymke)
        {
            foreach (KeyValuePair<string, int> pamoka in pazymke)
            {
                Console.WriteLine("{0} - {1}", pamoka.Key, pamoka.Value);
            }
        }

    }
}

