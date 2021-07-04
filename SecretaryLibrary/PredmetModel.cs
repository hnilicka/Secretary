using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SecretaryLibrary
{
    public class PredmetModel
    {
        // datova knihovna pro model Studijni Plany neboli Predmet; 
        // upresnit textem
        public PredmetModel()
        {
        }
        // jednoznacny identifikator je zkratka predmetu pr. AK8PO
        public string Zkratka { get; set; }
        public string Nazev { get; set; }
        public int PocetTydnu { get; set; }
        public int HodPrednaska { get; set; }
        public int HodCviceni { get; set; }
        public int HodSeminar { get; set; }
        // Zakonceni muze byt nasledujici: kl (klasifikovany zapocet); z, zk zde v kodu "zzk" (zapocet a zkouska);
        // z (zapocet), zk (zkouška)
        public enum Zakonceni { z, kl, zk, zzk }
        // je v pdf studijni plan ale nevyzadovano dle datamap
        // public int PocetKreditu { get; set; }
        public enum Jazyk { cz, en }
        //  defaultne je pocet 24 studentu, velmi casto 12 a u kombinovaneho studia muze byt 0
        public int VelikostTrida { get; set; }

        public List<SkupinaModel> Skupina { get; set; } = new List<SkupinaModel>();



    }
}
