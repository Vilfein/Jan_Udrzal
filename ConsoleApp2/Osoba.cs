using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Osoba
    {
        public Osoba(string jmeno, int vek)
        {
            Jmeno = jmeno;
            Vek = vek;
        }

        public string Jmeno {  get; set; }
        public int Vek {  get; set; }

        public override string? ToString()
        {
            return $"{Jmeno}, {Vek}let";
        }
    }
}
