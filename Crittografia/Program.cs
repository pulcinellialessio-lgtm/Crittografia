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
            char[] parolaTraspI = TraspInversa(chiave, Parola);

            Console.Write("Parola Trasposta Inversa: ");

            for (int i = 0; i < parolaTraspI.Length; i++)
            {
                Console.Write(parolaTraspI[i]);
            }

            Console.WriteLine("         ");

            return appoggio;
        }
        static char[] TraspInversa(int chiave, char[] appoggio)
        {
            char[] parolaTraspI = new char[appoggio.Length];
            int Diff2 = 0;
            int Diff1 = 0;
            int Diff3 = 0;

            for (int i = 0; i < appoggio.Length; i++)
            {
                Diff1 = i - chiave;
                
                if (i == 0)
                {
                    Diff2 = appoggio.Length - chiave;
                    parolaTraspI[Diff2] = appoggio[i];
                }
                else if (Diff1 < 0 && i != 0)
                {
                    Diff3 = appoggio.Length - i;
                    parolaTraspI[Diff3] = appoggio[i];
                }
                else
                {
                    parolaTraspI[Diff1] = appoggio[i];
                }
            }
            return parolaTraspI;
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

            Console.Write("Parola Sostituita: ");

            for (int i = 0; i < parolaSos.Length; i++)
            {
                Console.Write(parolaSos[i]);
            }

            Console.WriteLine("         ");

            char[] parolaTrasp = Trasposizione(alfabeto, chiave, Parola);

            Console.Write("Parola Trasposta: ");

            for (int i = 0; i < parolaTrasp.Length; i++)
            {
                Console.Write(parolaTrasp[i]);
            }

        }
    }
}