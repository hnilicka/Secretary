using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SecretaryLibrary
{
    public class PracovniStitekModel
    {
        public PracovniStitekModel()
        {
        }
        public string Nazev { get; set; }
        public List<PredmetModel> Predmety { get; set; } = new List<PredmetModel>();
        // Zakonceni muze byt nasledujici: kl (klasifikovany zapocet); z, zk zde v kodu "zzk" (zapocet a zkouska);
        // z (zapocet), zk (zkouška)
        public enum Zakonceni { kl, z, zk, zzk }
        public int PocetStudentu { get; set; }
        public int PocetHodin { get; set; }
        public int PocetTydnu { get; set; }
        public enum Jazyk { cz, en }
        // metoda pocet bodu za pracovni stitek
        private int PracovniStitekBody { get; set; }




    }
}
