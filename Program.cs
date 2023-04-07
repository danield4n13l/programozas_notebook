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
        public void set(string név, int szám = -1)
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
        static void Main(string[] args)
        {

            string asd = "nuiznf";
            string qwi = new String(new char[] {'h', 'e', 'l', 'l', 'o', '\x00'});
            System.Console.WriteLine(asd + "\n" + qwi);


        }
    }
}
