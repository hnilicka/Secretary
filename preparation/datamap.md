DATOVÁ STRUKTURA 

### Model1_Predmet 
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

### Model2_Zamestnanec 
Jmeno: 
Prijmeni: 
Email_pracovni: 
Email_soukromy: 
Tel_pracovni: 
Tel_soukromy: 
Uvazek:0% - 100%; 0 = Doktorand; 0,1 = 10%,.. 
Zamestnanec: True/False; if Uvazek = 0 then False (protože je Doktorand a ne zaměstnanec); other True 
Pracovni_stitek:  make a list /database of Predmet  if Zamestnanec marked in Predmet. Count for the Zamestnaec EN_Body:  Num and CZ_Body: Num 


### Model3_PoctyStudentu 
StudijniSkupina 
Definovana: Froma studia (Bc/Mgr); Studijni obor: Alfa;Forma studia: Prezencni/Kombinovane; Semestr: LS/ZS; Rocnik: 1;2;3/1;2; Pocet studentu: Num; Jazyk; EN/CZ 
Vytvorit formular na vytvoreni nove studijni skupiny a vlozeni poctu studentu! 

StudijniSkupina z Model3_PoctyStudentu musi Tajemnik rucne pripojit k "Zkratka" z Model1_Predmet. 
Generuj Pracovni_Stitek 
! Pokud dojde k editaci jakehokoliv štítu, musí se automaticky spustit kontrola pracovních štítků. Přepočti pracovní štítek. 1 Porovnat a vypočítat a smazat nebo vytvořit. 

Změna v XML NEBO DATABÁZE. 
Zruseni, kontrola duplicit, vymazat a aktualizovat. (navrhnout postup) 

### Model4_PracovniStitek 48:48 
Uvazkovy list 

Vygenerován s Vyucujici: Null Tajemnik rucne priradi. 
Kontrola platnosti pracovních štítků.  
Kontrola nepřiřazených pracovních štítků. 
Hlášení o nutnosti smazat pracovní štítek. 


### Model5_VahyPracovniBody 
GlobalConfig file:  
Cviceni: 1 
Prednaska: 1 
Zkouska:1,2 

### Formulare 
Pridej_Predmet 
Pridej_Skupinu 
Pridej_PracovniStitek (pro ty co se nevygenerovaly automaticky) 
Pridej_Zamestnance 
Priradit_PracovniStitek 
Odradit_PracovniStitek 

 

 

 



 
