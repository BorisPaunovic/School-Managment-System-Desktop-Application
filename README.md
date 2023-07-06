# School-Zavrsni-B-A























   School menagment sistem-Korisnicko uputstvo


Sadrzaj

3…………………………………………………………………………………………………Uvod
4……………………………………………………………………………Logovanje na aplikaciju
5…………………………………………………………………………....Kreiranje novog naloga
6……………………………………………………………………………….…...Rad na aplikaciji
7…………………………………………………………………………………..Pregled podataka
8……………………………………………………………………………………...Unos podataka
9…………………………………………………………………………………..Brisanje podataka
10…………………………………………………………………..…………..Azuriranje podataka
11………………………………………………………………………………….....Baza podataka
Uvod


School menagment sistem je aplikacija za lako rukovodjenje podacima jedne skole .

Dva glavna dela SMS su baza podataka [slika 1]i sama aplikacija [slika 2].


          Slika 1 - School menagment sistem/Dashboard![image](https://github.com/BorisPaunovic/School-Zavrsni-B-A/assets/119711363/f4cfcd06-1ff4-40ee-b4ca-340daf5cf33c)




Slika 2 – SMS Database diagram



Logovanje na aplikaciju




Da bi se SMS koristio potom pokretanja aplikacije  potrebno je uneti Username i password [slika3].








                                               Slika 3 – Logovanje na aplikaciju




U koliko su Username i password ispravni otvorice vam se Glavna stranica aplikacije „Main“.









Kreiranje novog naloga



U koliko ste novi korisnik ili zelite da napravite novi nalog potrebno je kliknuti na
 Sign in(Prijavi se) dugme -Dole desno na stranici za logovanje -[ Slika 3 ]









                                  Slika 4 – Stranica za kreiranje novog korisnika

Nakon popunjavanja neophodnih polja podacima moguce je kreirati nalog kao administrator ( Ovo ce vam dozvoliti da dodajete,brisete i menjate admin priviligije ostalih korisnika).

Kada se novi korisnik bude kreirao potrebno je logovati se u aplikaciju[ Slika 3 ]







      Rad na aplikaciji

 
Na glavnij stranici cete videti:
1.
 Quick menu - sa leve strane - sa nazivima komandi koje cete da koristite[ slika 5 ] :
      1.Dashboard (Prikaz svih kontroli)
      2.Courses (Prikaz svih kurseva)
      3.Students (Prikaz svih studenta)
      4.Teachers (Prikaz svih Profesora)
      5.Countries (Prikaz svih zemalja)
      6.Subjects (Prikaz svih predmeta u okviru jednog kuirsa)
      7.Users ( Prikaz svih korisnika / napomena: u koliko niste ulogovani kao administrator                ova koma nda vam nece biti prikazana) 
2.Otvorenu stranicu Dashborad koja ima istu ulogu kao i quick menu[Slika 5]

Napomena:Rad na celoj aplikaciji sa svim podacima je isti kao u ovom primeru.




Slika 5 - Glavna stranica


Za unos izmenu i brisanje podataka potrebno je izabrati stavku iz quick menu ili Dashboard[Slika 6].


      Pregled podataka
    
                                       
           
Svi podaci vezani za odredjenu temu su predstavljeni u tabeli u dnu stranice[Slika 6]
Na vrhu stranice su postavnjene kontrole za :
   1.Unos podataka[Gore levo]
   2.Brisanje podataka[Gore sredina]
   3.Azuriranje postojecih podataka iz liste [Gore desno]
   4.Linija za pretragu sa dodatim filterima na desnij strani [Drop down menu / Desno iznad        liste] 
   5.Dugme za Osvezavanje liste i dugme za pretragu [Iznad liste levo]


Pregled podataka se radi kao u standardnom browser-u uz koriscenje filtera .



                                  Slika 6 – Stranica za rukovodjenje i pregled podataka







       Unos  podataka                                   
 

Unos podata se vrsi kliktom na dugme add - Vrsta Podataka[Slika 6].
Time se otvara stranica za unos podataka[Slikan  7].
Potrebno je ispuniti sva polja . Nakon toga kliknuti dugme Sacuvaj-Save – na dnu.
U koliko je sve ispravno dobicete potvrdnu poruku.
U suprotnom izaci ce vam obavestenje da nesto niste ispunili kako treba[Slika 8]

                                             Slika 7 - Strana za unos novih podataka
                                                    Slika 8 – Greska u unosu
                                    
                                                       
     Brisanje podataka     


Za brisnje podataka je potrebno oznaciti sta zalite izbrisati iz liste [Slika 6] i kliknuti na Delete-Vrste podataka.
Pojavice se potvrda o brisanju [Slika 9] koju morate potvrdti ako ste sigurni da zelite obrisati nesto is liste.









Slika 9 - Potvrda o brisanju



Azuriranje Podataka

Azuriranje se vrsi na sledeci nacin:
1.Izabrati podatak iz tabele
2.Kliknuti dugme Update-vrsta podataka[Slika 6]
Ovim se otvara nova stranica za Azuriranje[Slika 10]
Postupak je slican kao na dodavanju podataka :
1.Ispunjavanje polja 
2.Klik na dugme sacuvaj-Save-
U slucaju da podaci nisu ispravni prikazace se  obavestenje [Slika 11]
                                              
                                                 Slika 10-Azuriranje podataka
                                                     
                                                         Slika 11 - Greska u unosu

                          Baza podataka

Baza podataka koriscena u SMS je Microsoft SQL to je relaciona baza podataka koja se sastoji od 9 tabela [Slika 12]




                                                  Slika 12- Baza podataka






