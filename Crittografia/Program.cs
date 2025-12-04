namespace Cifratura
{
    internal class Program
    {
        static char[] numeriC(char[] Parola, char[] alfabeto, int chiave)
        {
            for (int i = 0; i < Parola.Length; i++)
            {
                int j = 0;
                bool t = false;
                while (t == false)
                {
                    if (Parola[i] + chiave >= 26)
                    {
                        int diff = chiave - (26 - Parola[i]);
                        Parola[i] = alfabeto[diff];
                    }
                    if (Parola[i] == alfabeto[j])
                    {
                        Parola[i] = alfabeto[j + chiave];
                        t = true;
                    }



                    j++;
                }
            }

            return Parola;
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
        }
    }
}