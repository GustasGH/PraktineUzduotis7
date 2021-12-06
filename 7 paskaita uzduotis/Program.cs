using System;

namespace _7_paskaita_uzduotis
{
    internal class Program
    {

        public struct Pazymiai
        {
            public int pirmoTrimestroPazymis;
            public int antroTrimestroPazymis;
            public int trecioTrimestroPazymis;

            public Pazymiai(int pirmasPazymis, int antrasPazymis, int treciasPazymis)
            {
                pirmoTrimestroPazymis = pirmasPazymis;
                antroTrimestroPazymis = antrasPazymis;
                trecioTrimestroPazymis = treciasPazymis;
            }

            public void vidurkis()
            {
                int vidurkis = (pirmoTrimestroPazymis + antroTrimestroPazymis + trecioTrimestroPazymis) / 3;
                Console.WriteLine($"Triju trimestru vidurkis: {vidurkis}");
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            Pazymiai pazymiai;
            pazymiai.pirmoTrimestroPazymis = 6;
            pazymiai.antroTrimestroPazymis = 8;
            pazymiai.trecioTrimestroPazymis = 3;

            pazymiai.vidurkis();
        }
    }
}

// 1 tri int
//2 trimestro pazymis
//3 trimestro pazymis
//Int ( sudeti visus ir padalinti is 3)
//    naudoti struct (jame parasyti metoda kuris isveta metini vidurki, struc viduj deklaruoti kintamuosiu ir parasyt metoda kuris isveda metiniu pazymiu vidurki)

