use bmw_wawa;

drop table CarWawa;

create table CarWawa (
	Id int unsigned NOT NULL auto_increment,
	Seria varchar(200),
    Wersja varchar(200),
    Nadwozie varchar(200),
    Silnik char,
    Pojemnosc int,
    Moc int,
    Skrzynia char,
    Cena int,
    Kolor varchar(200),
    PRIMARY KEY(Id)
);

insert into CarWawa (Seria, Wersja, Nadwozie, Silnik, Pojemnosc, Moc, Skrzynia, Cena, Kolor)
values
("Seria 1", "120i (177KM) M6", "Hatchback / 3dr", 'B', 1598, 177, 'M', 112500, "Szafirowo czarny"),
("Seria 2", "220i (184KM) M6", "Coupe / 3dr", 'B', 1997, 184, 'M', 135700, "Srebrny Silverstone"),
("Seria 3", "320i xDrive (184KM) M6", "Sedan / 4dr", 'B', 1997, 184, 'M', 154600, "Czerwień Melbourne"),
("Seria 4", "430i (252KM) A8 Steptronic", "Coupe / 4dr", 'B', 1998, 252, 'A', 191877, "Błękit cesarski"),
("Seria 5", "528i (245KM) A8 Steptronic", "Sedan / 4dr", 'B', 1997, 245, 'A', 218118, "Biel mineralna"),
("Seria 5", "520d xDrive (190KM) A8 Steptronic", "Sedan / 4dr", 'D', 1995, 190, 'A', 214200, "Szary mineralny"),
("Seria 6", "640d xDrive (313KM) A8 Steptronic", "Cabrio / 2dr", 'D', 2993, 313, 'A', 462100, "Szary mineralny"),
("Seria 7", "750d xDrive (400KM) A8 Steptronic", "Sedan / 4dr", 'D', 2993, 400, 'A', 505400, "Szary mineralny"),
("X1", "18i sDrive (136KM) M6", "SUV / 5dr", 'B', 1499, 136, 'M', 129700, "Szafirowy czarny"),
("X3 ", "18d sDrive (150KM) A8 Steptronic", "SUV / 5dr", 'D', 1995, 150, 'A', 172777, "Srebrny Silverstone"),
("X4", "30d xDrive DPF (258KM) A8 Steptronic", "SUV / 5dr", 'D', 2993, 258, 'A', 269800, "Czerwień Melbourne"),
("X5 ", "35i xDrive (306KM) A8 Steptronic", "SUV / 5dr", 'B', 2979, 306, 'A', 292300, "Błękit cesarski"),
("X6", "50i xDrive (450KM) A8 Steptronic", "SUV / 5dr", 'B', 4395, 450, 'A', 402800, "Biel mineralna"),
("Z4 ", "28i sDrive (245KM) A8 Steptronic", "Roadster / 2dr", 'B', 1997, 245, 'A', 202559, "Szary mineralny"),
("i3", "0,6 (170 KM) A1 Range Extender", "Hatchback / 5dr", 'E', 647, 170, 'B', 174000, "Szary mineralny"),
("i8", "1,5 (362 KM) A0", "Coupe / 3dr", 'E', 1499, 362, 'B', 597000, "Szary mineralny");