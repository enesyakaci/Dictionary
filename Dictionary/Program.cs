using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<String, int> telefonKodu = new Dictionary<string, int>();
            telefonKodu.Add("Ankara", 312);
            telefonKodu.Add("Antalya", 242);
            telefonKodu.Add("Eskişehir", 222);
            telefonKodu.Add("Isparta", 246);
            telefonKodu.Add("İstanbul", 212);
            telefonKodu.Add("Kütahya", 274);

            foreach (var telefon in telefonKodu)
            {
                Console.WriteLine(telefon);
            }
        }
    }
}
