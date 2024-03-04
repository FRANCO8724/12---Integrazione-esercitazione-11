using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Integrazione_esercitazione_11
{
    internal class Scontrino
    {
        private string[] articoli;
        private int prezzo;
        private string nome;
        private int i = 0;

        public Scontrino()
        {
            articoli = new string[100];
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Aggiunta(string nome,int prezzo)
        {
            articoli[i] = nome + ";" + Convert.ToString(prezzo);
        }

        public int Totale()
        {
            int tot = 0;

            for(int E = 0;E<articoli.Length;E++)
            {
                if (articoli[E] != null)
                {
                    string[] prova = articoli[E].Split();
                    tot = tot + Convert.ToInt32(prova[1]);
                }  
            }


            return tot;
        }

        public void Ordina()
        { 
          
        }

        public string Cerca(string nome)
        {
            int p = 0;

            for(int E = 0; E<articoli.Length;E++)
            {
                if (articoli[E] != null)
                {
                    string[] prova = articoli[E].Split();

                    if (prova[0] == nome)
                    {
                        p = 1;

                        return "elemento trovato esso è : " + prova[0] + " prezzo:" + Convert.ToString(prova[1]);

                        break;
                    }
                }
            }
                return "elemento non trovato";
        }

        public void Quantità(int a ,int b)
        {
            articoli[b] = articoli[b] + ";" + a;
        }
    }
}
