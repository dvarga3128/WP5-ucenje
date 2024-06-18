select * from usluge where sifra=2;

update usluge set cijena= 700.50 where sifra=2;

update usluge set cijena = 400.42 where sifra=3;

-- svim uslugama smanji cijenu za 10%
select * from usluge;
update usluge set cijena = cijena * 0.9;
select * from usluge;

-- povećajte cijene svim smjerovima za 6,5%
update usluge set cijena = cijena * 1.065;

-- smanjite svim smjerovima cijenu za 10 €
update usluge set cijena = cijena - 10;

select * from klijenti;
--update klijenti set naziv ='Prpić';
