use bmw_wroclaw;

drop table Car;

create table Car (
	Id int unsigned NOT NULL auto_increment,
	Series varchar(200),
    Version varchar(200),
    Body varchar(200),
    FuelType char,
    EngineCapacity int,
    Power int,
    GearboxType char,
    Price int,
    Colour varchar(200),
    PRIMARY KEY(Id)
);

insert into Car (Series, Version, Body, FuelType, EngineCapacity, Power, GearboxType, Price, Colour)
values
("Seria 1", "116i (109KM) M6", "Hatchback / 3dr", 'B', 1499, 109, 'M', 94600, "Błękit Estoril"),
("Seria 2", "214d (95KM) M6", "MPV / 5dr", 'D', 1496, 95, 'M', 118300, "Jatoba"),
("Seria 3", "320d (163KM) M6 EfficientDynamics Edition", "Sedan / 4dr", 'D', 1995, 163, 'M', 155000, "Żółty Austin"),
("Seria 4", "430i (252KM) M6", "Coupe / 4dr", 'B', 1998, 252, 'M', 182400, "Niebieski Yas Marina"),
("Seria 5", "528i (245KM) A8 Steptronic", "Sedan / 4dr", 'B', 1997, 245, 'A', 218118, "Pomarańcz Sakhir II"),
("Seria 6", "640d xDrive (313KM) A8 Steptronic", "Cabrio / 2dr", 'D', 2993, 313, 'A', 462100, "Srebrny platynowy"),
("Seria 7", "740e xDrive iPerformance (326KM) A8 Steptronic", "Sedan / 4dr", 'E', 1998, 326, 'A', 483100, "Niebieski śródziemnomorski"),
("X1", "18i xDrive (150KM) M6", "SUV / 5dr", 'B', 1995, 150, 'M', 153800, "Niebieski Yas Marina"),
("X3 ", "18d sDrive (150KM) M6", "SUV / 5dr", 'D', 1995, 150, 'M', 163300, "Pomarańcz Sakhir II"),
("X4", "20d xDrive (190KM) M6", "SUV / 5dr", 'D', 1995, 190, 'M', 195700, "Jatoba"),
("X5 ", "25d xDrive (231KM) A8 Steptronic", "SUV / 5dr", 'D', 1995, 231, 'A', 253500, "Żółty Austin"),
("X6", "M50d (381KM) A8 Steptronic", "SUV / 5dr", 'D', 2993, 381, 'A', 429900, "Srebrny platynowy"),
("Z4 ", "18i sDrive (156KM) M6", "Roadster / 2dr", 'B', 1997, 156, 'M', 160100, "Niebieski śródziemnomorski");