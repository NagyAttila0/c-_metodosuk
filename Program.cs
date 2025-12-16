
using System.Xml.Serialization;


namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UdvozloKep();
            List<string> menupontok = new List<string>();
            menupontok.Add("Kerület számítása");
            menupontok.Add("Terület számítása");
            menupontok.Add("Pitagorasz tételel számítás");
            menupontok.Add("Háromszög-e");
            menupontok.Add("Kilépés");
            ListazMenu(menupontok);
            Console.WriteLine("Vége!");
        }

        
        private static void UdvozloKep()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Üdvözlöm a háromszög szuper alkalmazásban!");


        }
        private static int Terulet(int hossz, int szeles)
        {
            return hossz * szeles;
        }
        private static int Kerulet(int Ahossz, int Bhossz)
        {
            return 2 * (Ahossz + Bhossz);
        }
        private static int Pitagor(int ahossz, int bhossz)
        {
            return Convert.ToInt32(Math.Sqrt((ahossz * ahossz) + (bhossz * bhossz)));
        }
        private static bool HaromszogLetezik(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
        //A kódot Nagy Attila írta
        private static void ListazMenu(List<string> menupontok)
        {

            bool kilepes = false;

            while (!kilepes)
            {
                Console.WriteLine("\nVálassz egy menüpontot:");

                for (int i = 0; i < menupontok.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menupontok[i]}");
                }

                Console.Write("Választás (1-5): ");
                string valasz = Console.ReadLine();

                switch (valasz)
                {
                    case "1":
                        Console.Write("Add meg az A oldalt: ");
                        int a = int.Parse(Console.ReadLine());

                        Console.Write("Add meg a B oldalt: ");
                        int b = int.Parse(Console.ReadLine());

                        int kerulet = Kerulet(a, b);
                        Console.WriteLine($"A kerület: {kerulet}");
                        break;

                    case "2":
                        Console.Write("Add meg a hosszúságot: ");
                        int hossz = int.Parse(Console.ReadLine());

                        Console.Write("Add meg a szélességet: ");
                        int szeles = int.Parse(Console.ReadLine());

                        int terulet = Terulet(hossz, szeles);
                        Console.WriteLine($"A terület: {terulet}");
                        break;

                    case "3":
                        Console.Write("Add meg a hosszúságot: ");
                        int Ahossz = int.Parse(Console.ReadLine());

                        Console.Write("Add meg a szélességet: ");
                        int Bhossz = int.Parse(Console.ReadLine());
                        int pitager = Pitagor(Ahossz, Bhossz);
                        Console.WriteLine($"Az eredmény {pitager}");
                        break;
                    case "4":
                        Console.Write("Add meg az a hosszúságot: ");
                        int ahossz = int.Parse(Console.ReadLine());

                        Console.Write("Add meg az a hosszúságot: ");
                        int bhossz = int.Parse(Console.ReadLine());
                        Console.Write("Add meg az a hosszúságot: ");
                        int chossz = int.Parse(Console.ReadLine());
                        bool haromszogE = HaromszogLetezik(ahossz, bhossz, chossz);
                        if (haromszogE == true)
                        {
                            Console.WriteLine("Igen");
                        }
                        else
                        {
                            Console.WriteLine("Nem");
                        }
                            break;
                    case "5":
                        kilepes = true;
                        Console.WriteLine("Kilépés...");
                        break;
                    default:
                        Console.WriteLine("Érvénytelen választás!");
                        break;
                }
            }
        }
    }

}

