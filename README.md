# HON-ING d.o.o.


## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
:-----------  | :------------------ | :---: | :-------------------:
Helena Potočki | hpotocki@foi.hr | 0016129570 | HelenaPotocki
Iva Kozmač | ikozmac@foi.hr | 0016133068 | IvaKozmac
Luka Kemenović | lkemenovi@foi.hr | 0016133463 | LukaKemo
Žan Žlender | zzlender@foi.hr | 0016123668 | zanzlender

## Opis domene

Poslovni cilj ovog projekta je napraviti nacrt, arhitekturu i prototip buduće aplikacije za interno korištenje zaposlenika **HON-ING d.o.o.**. Aplikacija bi asistirala zaposlenicima u svakodnevnim aktivnostima u poduzeću te pomogla u informiranju o radu. Aplikacija se sastoji od početnog sučelja za prijavu i autentifikaciju korisnika te se prema tome određuje kojoj skupini korisnika pripada. Prema tome korisniku se otvaraju mogućnosti koje su u domeni njegovih zaduženja. Aplikacija ima mogućnost pregleda rasporeda po smjenama tako da svaki zaposlenik ima uvid u vlastite radne smjene koje određuje i unosi voditelj odjela. Također, korisnik može birati slobodne dane i rezervirati godišnji odmor prikazanog u obliku kalendara. Omogućiti će se obilježavanje ulaza i izlaza stavki skladišta, čime se postiže efikasnije vođenje evidencije materijala i gotovih proizvoda.
Kako bi se lakše unaprijedilo poslovanje, voditeljima će biti dostupna grafička statistika podataka. Zaposlenici će kroz zajednički news feed moći pratiti obavijesti i novosti koje su bitne za cjelokupno poduzeće. U sklopu odjela *Prodaje*, omogućene su forme za unos narudžbi, kreiranje ponuda i radnih naloga u svrhu ubrzavanja procesa dostavljanja finalnog proizvoda. 

## Specifikacija projekta
Funkcionalnosti, odnosno informacije, koje aplikacija treba sadržavati:
 -  Prijava u sustav
 -  Administriranje zaposlenika (unos/izmjena/dodavanje/uloga zaposlenika i sl.)
 -  Raspored smjena zaposlenika
 -  Pregled i rezervacija godišnjeg odmora i slobodnih dana
 -  Statistika za unaprijeđenje poslovanja 
 -  Vođenje evidencije materijala i gotovih proizvoda
 -  Generalne obavijesti i novosti
 -  Zaprimanje narudžbe i kreiranje ponude 

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login | Prijava u aplikaciju ovisno o ulozi (administrator, voditelj, zaposlenici po odjelima, ...), osmišljavanje načina autentifikacije korisnika i spriječavanje zlouporabe | Žan Žlender
F02 | Administriranje | Osmišljavanje i izrada programskog rješenja za dodavanje korisnika u bazu podataka, administrativni pregled nad ostalim funkcionalnostima i super administracija, odnosno kreacija poduzeća i dodavanje zaposlenika. | Žan Žlender
F03 | Raspored smjena | Kreiranje programskog rješenja pomoću kojeg zaposlenici mogu pratiti svoje smjene koje unosi voditelj odjela, te automatizirano slanje rasporeda putem maila u obliku PDF-a. | Helena Potočki
F04 | Godišnji odmor i slobodni dani | Osmišljavanje i kreiranje kalendara u kojemu zaposlenici mogu proizvoljno rezervirati željene slobodne dane i godišnje odmore. Automatizirano, periodičko slanje maila za obavještavanje zaposlenika o završetku godišnjeg odmora/slobodnih dana.  | Iva Kozmač
F05 | Statistika | Osmišljavanje i izrada programskog rješenja za prikaz statističkih podataka u obliku grafikona, te mogućnost izvoza u PDF obliku.| Luka Kemenović
F06 | Vođenje evidencije | Izrada formi za pračenje ulaznih i izlaznih stavki, iz ili u skladište, te praćenje stanja skladišta. | Iva Kozmač
F07 | Obavijesti i novosti | Kreiranje sučelja za prikaz informacija, obavijesti i novosti u poduzeću. Obavijesti također dolaze u obliku Windows Notifikacija.| Luka Kemenović
F08 | Prodaja | Izrada formi za unos narudžbi, kreiranja ponuda prema narudžbama i kreiranje radnih naloga. Također, biti će implementirana mogućnost ispisa formi u PDF oblik. | Helena Potočki
F09 | Upravljanje ulogama | Dodavanje administratora za određeno poduzeće koji može svojim zaposlenicima davati ovlasti za pojedine funkcije aplikacije. | Žan Žlender

## Tehnologije i oprema
Glavno integrirano razvojno okruženje u kojoj ćemo razvijati ovu desktop aplikaciju jest *Microsoft Visual Studio 2019, Community Eddition* na *Windows 10* operacijskom sustavu. Za izradu baze podataka koristit će se *SQL Server Management Studio*. Verzioniranje koda vršit će se preko *GitHub-a*, a dokumentaciju preko *GitHub Wiki-ja*. Za sve potrebne dijagrame i slike koristiti ćemo web aplikaciju *Visual Paradigm Community Edition*.
