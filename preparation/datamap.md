DATOVÁ STRUKTURA 

 
Povinny atribut 
Vhodny atribut 
Doplňující atribut 
Přenos z jineho pole 

 

 

 

Model1_Predmet 
Moodle - Studijní plány - definice předmětu 

Pole:  
Zkratka: Alfanumeric; Lenght: 5; Fix 
Language: "EN" or "CZ" 
Body: Num 
Semestr: "ZS" YES/NO and "LS" YES/NO 
Prednaska: Num; ZS; LS 
Seminar: Num; ZS; LS 
Cviceni: Num; ZS; LS 
Ukonceni: zapocet; klasifikovany zapocet; zkouska (and) 
Kapacita (Trida): Num; Suma studentu zapsanych v "Zkratka" vydel polem "Kapacita" a vytvoř "Zkratka"&"_"&"Integer++" pokracuj dokud  zbyvajici pocet studentu neni mensi nebo roven "Kapacita". 
Kredity: Num 
Nazev: Alfanumeric; Lenght: 50; Max 
Garant (Vyucujici): "Přijmeni; Jmeno;"  "Přijmeni; Jmeno;" "Přijmeni; Jmeno;"  

 

Model2_Zamestnanec 
Jmeno: 
Prijmeni: 
Email_pracovni: 
Email_soukromy: 
Tel_pracovni: 
Tel_soukromy: 
Uvazek:0% - 100%; 0 = Doktorand; 0,1 = 10%,.. 
Zamestnanec: True/False; if Uvazek = 0 then False (protože je Doktorand a ne zaměstnanec); other True 
Pracovni_stitek:  make a list /database of Predmet  if Zamestnanec marked in Predmet. Count for the Zamestnaec EN_Body:  Num and CZ_Body: Num 
