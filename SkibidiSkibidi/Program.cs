namespace SkibidiSkibidi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string sas;
            string pes;
            for (int sax = 0; sax < 4;)
            {
            Console.WriteLine("Nomati");
            pes = Console.ReadLine();
            Console.WriteLine("Passworda");
            sas = Console.ReadLine();
                switch (sas)
                {
                    case "Cappio39":
                        sax = sax + 1;
            Console.WriteLine("passwordato bene, ciao " + pes + " sei a " + sax + " accessi effettuati");
                        Console.WriteLine("_________________________________________________________________");
                        break;
                    default:
                        Console.WriteLine("Password errata, booo, sei a " + sax + " accessi effettuati");
                        Console.WriteLine("_________________________________________________________________");
                        a++;
                        break;
                }
            }
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine("accesso effettuato");
            Console.WriteLine("hai fatto " + a + " tentativi falliti");

        }
    }
}