using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace SecretaryLibrary
{
    public class ZamestnanecModel
    {
        public ZamestnanecModel()
        {
        }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string FullName
       {
           get
           {
               return $"{Jmeno} {Prijmeni}";
           }            
       }
        public string EmailPracovni { get; set; }
        public string EmailSoukromy { get; set; }
        // toto nebude vlastnost ale metoda = metoda je privat
        private int PracovniBodyBezEn;
        private int PracovniBody;
        bool Doktorand = false;
        // 0 az 1; 0 je zamestnanec na dohodu nebo doktorand; jinak procento coz umoznuje double
        public double Uvazek { get; set; }
        private List<PracovniStitekModel> Predmet { get; set; } = new List<PracovniStitekModel>();


    }

}
