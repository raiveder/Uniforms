CREATE TABLE professii(
Kod_professii int primary key identity(1,1) NOT NULL,
Name_professii nvarchar(50) NOT NULL);

create table dolgnosti(
Kod_dolgnosti int primary key identity(1,1) NOT NULL,
Name_dolgnosti nvarchar(50) NOT NULL);

create table otdel(
Kod_otdela int primary key identity(1,1) NOT NULL,
Name_otdela nvarchar(50) NOT NULL);

create table sotrudniki(
Kod_sotrudnika int primary key identity(1,1) NOT NULL,
Surname nvarchar(50) NOT NULL,
Names nvarchar(50) NOT NULL,
Patronymic nvarchar(50),
Date_birthday date NOT NULL,
Telephone nvarchar(50) NOT NULL,
Kod_professii int NOT NULL,
Kod_dolgnosti int NOT NULL,
Kod_otdela int NOT NULL,
Foreign key (Kod_professii) references professii(Kod_professii),
Foreign key (Kod_dolgnosti) references dolgnosti(Kod_dolgnosti),
Foreign key (Kod_otdela) references otdel(Kod_otdela));


create table postavschiki(
Kod_postavschika int primary key identity(1,1) NOT NULL,
Name_postavschika nvarchar(50) NOT NULL,
FIO_contact_face nvarchar(50) NOT NULL,
Telephone_contact_face nvarchar(50) NOT NULL,
INN int NOT NULL);

create table vid_uniforms(
Kod_vida int primary key identity(1,1) NOT NULL,
Names nvarchar(50) NOT NULL);

create table uniforms(
Kod_uniform int primary key identity(1,1) NOT NULL,
Names nvarchar(50) NOT NULL,
Kod_vida int NOT NULL,
Cost money NOT NULL,
Kol_vo int NOT NULL,
Srok_use nvarchar(50) NOT NULL,
Foreign key (Kod_vida) references vid_uniforms(Kod_vida));


create table postavki(
Kod_postavki int primary key identity(1,1) NOT NULL,
Date_postupleniya date NOT NULL,
Num_documenta int NOT NULL,
Kod_postavschika int NOT NULL,
Kod_uniform int NOT NULL,
Kol_vo int NOT NULL,
Foreign key (Kod_postavschika) references postavschiki(Kod_postavschika),
Foreign key (Kod_uniform) references uniforms(Kod_uniform));


create table give_uniforms(
Kod_give int primary key identity(1,1) NOT NULL,
Kod_uniform int NOT NULL,
Kod_sotrudnika int NOT NULL,
Date_give date NOT NULL,
Kol_vo int NOT NULL,
Foreign key (Kod_uniform) references uniforms(Kod_uniform),
Foreign key (Kod_sotrudnika) references sotrudniki(Kod_sotrudnika));

create table change_uniforms(
Kod_change int primary key identity(1,1) NOT NULL,
Kod_uniform int NOT NULL,
Kod_sotrudnika int NOT NULL,
Date_change date NOT NULL,
Kol_vo int NOT NULL,
Foreign key (Kod_uniform) references uniforms(Kod_uniform),
Foreign key (Kod_sotrudnika) references sotrudniki(Kod_sotrudnika));

create table logined(
login nvarchar(50) NOT NULL,
password nvarchar(50) NOT NULL);