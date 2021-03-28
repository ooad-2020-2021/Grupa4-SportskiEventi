# Sport Court (Grupa4-SportskiEventi)

# Logo:
![Logo](https://i.imgur.com/6Rc1HSp.png)

# Clanovi:
- [Muhamed Omerović](https://github.com/momerovic4)  
- [Kenan Selimović](https://github.com/KenanSelimovic)
- [Adnan Palavra](https://github.com/plvr99)

# Opis teme: 
 Aplikacija služi za pregled i rezervisanje terena za razne vrste sportova. Znamo da je jako teško uskladiti i rezervisati baš onaj termin koji vama odgovara zato ova aplikacija olakšava i ubrzava sam proces odabira i rezervisanja termina. Također, pored samog rezervisanja terena u odabranom terminu moguć je i pregled svih sportskih objekata na mapi.

# Funkcionalni zahtjevi:
- Mogućnost prijave na sistem sa različitim privilegijama (gost, registrovani korisnik i admin)
- Mogućnost pregleda lokacija terena.
- Mogućnost pregleda termina.
- Odabir (rezervisanje) sporta, termina i sale u željenom terminu.
- Dodavanje novih sportskih objekata i njihovih specifikacija
- Editovanje postojećih sportskih objekata.
- Prikaz sportskih objekata na mapi.
- Editovanje vec postojecih termina
- Mogućnost dodavanja komentara uz zahtjev za rezervisanje termina
- Automatsko pronalaženje najbližih sala koristenjem GPS usluge
- Slanje notifikacija korisniku o potencijalnom pomjeranju termina ili potvrđenom terminu

# Nefunkcionalni zahtjevi:
- Responzivan korisnički interfejs na svim uređajima i operativnim sistemima
- Notifikacije o verifikaciji termina
- Verifikacija i validacija podataka pri registrovanju na sistem
- Pregled terena po sportovima
- Pregled terena po terminima
- Pregled terena po lokaciji
- Zabranjeni termini rezervacije nakon vremena specificiranog od strane admina/vlasnika terena

# Akteri:
- ### Gost: 
   ima mogućnost pregleda lokacija terena i svih termina, ali ne i njihovo rezervisanje.
- ### Registrovani korisnik: 
   ima mogućnost pregleda lokacija terena i svih termina, rezervisanje terena u određenom terminu kojeg plaća preko online servisa.
- ### Vlasnici sportskih objekata: 
   ima mogućnosti da doda i izmjeni informacije o sportskom objektu(sali).
- ### Admin: 
   ima mogućnost da nadgleda cijeli sistem, dodavanje terena, izmjenu informacija o terenu, pregled korisnika i transakcija itd.
