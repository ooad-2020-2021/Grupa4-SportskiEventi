# Sport Court (Grupa4-SportskiEventi)

# Logo:
![Logo](https://i.imgur.com/6Rc1HSp.png)

# Clanovi:
- [Muhamed Omerović](https://github.com/momerovic4)  
- [Kenan Selimović](https://github.com/KenanSelimovic)
- [Adnan Palavra](https://github.com/plvr99)

# Opis teme: 
 Aplikacija sluzi za pregled i rezervisanje terena za razne vrste sportova. Znamo da je jako teško uskladiti i rezervisati baš onaj termin koji vama odgovara zato ova aplikacija olaksava i ubrzava sam proces odabira i rezervisanja termina. Također, pored samog rezervisanja terena u odabranom terminu moguc je i pregled svih sportskih objekata na mapi.

# Funkcionalni zahtjevi:
- Mogucnost prijave na sistem sa razlicitim privilegijama (gost, registrovani korisnik i admin)
- Mogucnost pregleda lokacija terena.
- Mogucnost pregleda termina.
- Odabir (rezervisanje) sporta, termina i sale u zeljenom terminu.
- Dodavanje novih sportskih objekata i njihovih specifikacija
- Editovanje postojecih sportskih objekata.
- Prikaz sportskih objekata na mapi.
- Editovanje vec postojecih termina
- Mogucnost dodavanja komentara uz zahtjev za rezervisanje termina
- Automatsko pronalazenje najblizih sala koristenjem GPS usluge
- Slanje notifikacija korisniku o potencijalnom pomjeranju termina ili potvrđenom terminu

# Nefunkcionalni zahtjevi:
- Responzivan korisnički interfejs na svim uređajima i operativnim sistemima
- Notifikacije o verifikaciji termina
- Verifikacija i vlaidacija podataka pri regirstorvanju na sistem
- Pregled terena po sportovima
- Pregled terena po terminima
- Pregled terena po lokaciji
- Zabranjeni termini rezervacije nakon vremena specificiranog strane admina/vlasnika terena

# Akteri:
- ### Gost: 
   ima mogućnost pregleda lokacija terena i svih termina, ali ne i njihovo rezervisanje.
- ### Registrovani korisnik: 
   ima mogućnost pregleda lokacija terena i svih termina, rezervisanje terena u određenom terminu kojeg placa preko online servisa.
- ### Vlasnici sportskih objekata: 
   ima mogucnosti da doda i izmjeni informacije o sportskom objektu(sali).
- ### Admin: 
   ima mogucnost da nadgleda cijeli sistem, dodavanje terena, izmjenu informacija o terenu, pregled korisnika i transakcija itd.
