use master
go
drop database if exists ucenjedizajn
go 
create database ucenjedizajn
go
use ucenjedizajn

create table klijenti(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
email varchar(100) not null
);

create table projekti(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
usluga int null,
dizajner int null,
klijent int null
);

create table usluge(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
cijena decimal (18,2) null
);

create table dizajneri(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
email varchar(100) not null
);

alter table projekti add foreign key (klijent) references klijenti(sifra);
alter table projekti add foreign key (usluga) references usluge(sifra);
alter table projekti add foreign key(dizajner) references dizajneri(sifra);

--select * from klijenti

insert into klijenti (naziv,email) values
('LegitFirma','legitfirma@gmail.com'),
('Pero Peri?', 'pperic@gmail.com'),
('Jošjednafirma','firma22@gmail.com');


