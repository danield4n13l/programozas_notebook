using System;
using System.Collections.Generic;
using System.IO;

namespace Program
{
    /// <summary>
    /// Egy példa a struktúrák használatára.
    /// </summary>
    /// <see langword="struct"/>
    struct Könyv
    {
        public string név;
        public int szám;
        public void Set(string név, int szám = -1)
        {
            this.név = név;
            this.szám = szám;
        }
    }
    class Program
    {
        public static int Négyzet(int x) => x * x;



        /// <summary>
        /// Köszönt.
        /// </summary>
        /// <param name="név">A név akit köszönt</param>
        /// <example>
        /// Egy példa erre:
        /// <code>
        ///     Szia("Péter");
        /// </code>
        /// Kimenet:    <c>Szia Péter!</c>
        /// </example>
        static void Szia(string név) => Console.WriteLine($"Szia ${név}!");

        /// <summary>
        /// Minden C#-program entrypointja: a Main() eljárás
        /// </summary>
        /// <param name="args">A programnak bejuttatott indítási paraméterek listája</param>
        static void Main(string[] args)
        {

            string asd = "nuiznf";
            string qwi = new string(new char[] { 'h', 'e', 'l', 'l', 'o', '\x00' });
            Console.WriteLine(asd + "\n" + qwi);

            Szia("Petike");
        }
    }
}
