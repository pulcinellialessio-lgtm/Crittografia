using System.IO.Compression;

namespace Cifratura
{
    internal class Program
    {
        static char[] numeriC(char[] Parola, char[] alfabeto, int chiave)
        {
            int Diff = 0;
            int diff = 0;
            int Somm = 0;

            for (int i = 0; i < Parola.Length; i++)
            {
                int j = 0;
                bool t = false;

                while (t == false)
                {

                    if (Parola[i] == alfabeto[j])
                    {
                        t = true;

                        if (j + chiave >= 26)
                        {
                            Somm = alfabeto[j] + chiave;
                            Diff = Somm - alfabeto[j];
                            diff = chiave - Diff;

                            Parola[i] = alfabeto[diff];
                        }
                        else
                        {
                            Parola[i] = alfabeto[j + chiave];
                        }
                    }

                    j++;
                }
            }

            return Parola;
        }
        static char[] Trasposizione(char[] alfabeto, int chiave, char[] Parola)
        {
            char[] appoggio = new char[Parola.Length];
            int Somm = 0;
            int Diff = 0;

            for(int i = 0; i < Parola.Length; i++)
            {
                Somm = i + chiave;

                if (i + chiave >= Parola.Length)
                {
                    
                    Diff = Somm - Parola.Length;

                    appoggio[Diff] = Parola[i];
                }
                else
                {
                    appoggio[Somm] = Parola[i];
                }
                
            }

            return appoggio;
        }
        static char[] TraspInversa(char[] alfabeto, int chiave, char[] appoggio)
        {
            char[] inverso = new char[appoggio.Length];
            int Somm = 0;
            int Diff = 0;

            for (int i = 0; i < appoggio.Length; i++)
            {
                Somm = i + chiave;

                if (i + chiave >= appoggio.Length)
                {

                    Diff = Somm - appoggio.Length;

                    appoggio[Diff] = appoggio[i];
                }
                else
                {
                    appoggio[Somm] = appoggio[];
                }

            }

            return appoggio;
        }
        static void Main(string[] args)
        {
            char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("dammi la parola");
            string parola = Console.ReadLine();

            char[] Parola = parola.ToCharArray();

            Console.WriteLine("dammi la chaive");
            int chiave = Convert.ToInt32(Console.ReadLine());

            char[] parolaSos = numeriC(Parola, alfabeto, chiave);

            for (int i = 0; i < parolaSos.Length; i++)
            {
                Console.Write(parolaSos[i]);
            }

            Console.WriteLine("         ");

            char[] parolaTrasp = Trasposizione(alfabeto, chiave, Parola);

            for (int i = 0; i < parolaTrasp.Length; i++)
            {
                Console.Write(parolaTrasp[i]);
            }
        }
    }
}