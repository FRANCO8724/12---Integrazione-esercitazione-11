using _12___Integrazione_esercitazione_11;
using System;
using System.Runtime.Intrinsics;

class Program
{
    public static void Main(string[] args, Scontrino scontrino, Scontrino scontrino)
    {
        

        int scelta = 0;
        Scontrino miaIstanza = new Scontrino();

        //stuttura menù
        do
        {
            //stampa delle opzioni

            Console.Clear();
            Console.WriteLine("12 - Integrazione esercitazione 11");
            Console.WriteLine(" ");
            Console.WriteLine("          1 - Aggiunta: ");
            Console.WriteLine("          2 - Totale: ");
            Console.WriteLine("          3 - Ordina: ");
            Console.WriteLine("          4 - Ricerca: ");
            Console.WriteLine("          5 - Calcolo: ");
            Console.WriteLine(" ");
            Console.WriteLine("0 - uscita");
            Console.WriteLine(" ");
            //scelta dell'opzione
            Console.WriteLine("inserisci la scelta: ");
            scelta = int.Parse(Console.ReadLine());


            //esecuzione dell'opzione
            switch (scelta)
            {
                case 1:
  

                    Console.WriteLine("Inserisci nome podotto: ");
                    string a = Console.ReadLine();

                    Console.WriteLine("Inserisci prezzo prodotto: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    miaIstanza.Aggiunta(a, b);

                    break;

                    case 2 :

                    decimal tot = miaIstanza.Totale();
                    Console.WriteLine("Il totale è: " + tot + " $");

                    break;

                case 3:

                    

                    break;

                case 4:

                    Console.WriteLine("Inserisci prodotto da cercare: ");
                    string cerc = Console.ReadLine();
                    string cercato = miaIstanza.Cerca(cerc);
                    Console.WriteLine(cercato);

                    break;

                case 5:

                    int y = 0;

                    for(int i=0;i<100;i++)
                    {

                        Console.WriteLine("Inserisci le quantità di ciascun prodotto:: ");
                        int l = Convert.ToInt32(Console.ReadLine());

                        int camb = miaIstanza.Quantità(l,y);

                    }

                    break;

                   



            }
            Console.ReadLine();
        } while (scelta != 0);


    }

}
}