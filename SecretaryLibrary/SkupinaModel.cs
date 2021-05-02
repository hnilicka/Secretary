using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace SecretaryLibrary
{
    public class SkupinaModel
    {   // TimCorrey TimeStamp: (HH:MM 01:50)
        // datova knihovna Studijni skupiny; Studijni skupna se rozdeluje do pracovnich stitku.
        // Pocet studentu je nutne manualne vlozit nejsou automaticky napocteny ze seznanu List<Predmet>

        public SkupinaModel()
        {
        }

        public string Zkratka { get; set; }
        public string Nazev { get; set; }
        public int Rocnik { get; set; }
        // enum dava vyctum hodnot cisla od 0
        // priklad LS = 0; ZS = 1; 
        public enum Semestr {LS, ZS}
        public int PocetStudentu { get; set; }
        public enum FormaStudia { P,K}
        public enum TypStudia { Bc, Ing }
        public enum Jazyk { cz, en}
        // public List <Predmet>

    }
}
