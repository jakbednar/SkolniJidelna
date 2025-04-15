using System.Threading.Channels;

namespace SkolniJidelna;

class Program
{
    static void Main(string[] args)
    {
        int penezenka = 500;
        int cena = 50;
        string[] den = { "PO", "UT", "ST", "CT", "PA" };
        string[] cisloObeda = new string[5];
        for (int i = 0; i < 5; i++)
        {
            cisloObeda[i] = " ";
        }

        Prihlaseni();
        
        while (true)
        {
            Menu();

            Console.Write("\nZadejte den, ktery chcete narazit nebo odrazit: ");
            int volba = int.Parse(Console.ReadLine());
            
            Objednani(volba);
        }

        void Menu()
        {
            Console.WriteLine($"Cena obědů: {cena}Kč | Stav peněženky: {penezenka}");
            Console.WriteLine("VOLBA 1 | Pondeli: Halusky");
            Console.WriteLine("VOLBA 2 | Utery: Rizek");
            Console.WriteLine("VOLBA 3 | Streda: Gulas");
            Console.WriteLine("VOLBA 4 | Ctvrtek: Svickova");
            Console.WriteLine("VOLBA 5 | Patek: Salat");
        
            Console.WriteLine("PO  UT  ST  CT  PA");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"[{cisloObeda[i]}] ");
            }
        }

        void Objednani(int volba)
        {
            if (cisloObeda[volba - 1] == "x")
            {
                Console.Clear();
                Console.WriteLine($"Opravdu chcete odrazit oběd v {den[volba - 1]}? y/n");
                if (Console.ReadLine() == "y")
                {
                    Console.Clear();
                    cisloObeda[volba - 1] = " ";
                    Console.WriteLine($"Oběd odražen. Stav peněženky: {penezenka}");
                    penezenka = penezenka + cena;
                    volba = 0;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Akce zrušena.");
                    volba = 0;
                }
            }

            if (volba >= 1 && volba <= 5)
            {
                Console.Clear();
                cisloObeda[volba - 1] = "x";
                penezenka = penezenka - cena;
                Console.WriteLine($"Oběd naražen. Stav peněženky: {penezenka}");
            }
        }

        void Prihlaseni()
        {
            string heslo = "123";
            int pokus = 0;

            while (pokus < 3)
            {
                Console.Write("Zadejte heslo: ");
                string vstup = Console.ReadLine();

                if (vstup == heslo)
                {
                    Console.WriteLine("Přihlášení bylo úspěšné.");
                    return;
                }
                else
                {
                    pokus++;
                    Console.WriteLine($"Špatné heslo. Pokus {pokus}/3");
                }
            }

            Console.WriteLine("Přesáhl jste počet pokusů. Konec.");
            Environment.Exit(0);        }
    }
}
