namespace SkolniJidelna;

class Program
{
    static void Main(string[] args)
    {
        string[] den = { "PO", "UT", "ST", "CT", "PA" };
        string[] cisloObeda = new string[5];
        for (int i = 0; i < 5; i++)
        {
            cisloObeda[i] = " ";
        }

        while (true)
        {
            Menu();

            Console.Write("\nZadejte den, ktery chcete narazit nebo odrazit: ");
            
            int volba = int.Parse(Console.ReadLine());

            if (cisloObeda[volba - 1] == "x")
            {
                Console.Clear();
                Console.WriteLine($"Opravdu chcete odrazit oběd v {den[volba - 1]}? y/n");
                if (Console.ReadLine() == "y")
                {
                    Console.Clear();
                    cisloObeda[volba - 1] = " ";
                    Console.WriteLine("Oběd odražen.");
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
                Console.WriteLine("Oběd naražen.");
            }
        }
        void Menu()
        {
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
    }
}
