using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MojeDatabase
    {
        private List<Osoba> lidi;

        public MojeDatabase()
        {
            lidi = new List<Osoba>();
        }

        public void PridatZaznam(Osoba osoba)
        {
            lidi.Add(osoba);
        }

        public void Vypis() => lidi.ForEach(x => Console.WriteLine(x));

        public void Vyhledej(string jmeno)
        {
            var hledany = lidi.Where(x => x.Jmeno == jmeno).FirstOrDefault();
            Console.WriteLine(hledany);
        }

       // LINQ - dotazovací jazyk
    }
}
