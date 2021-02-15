create table Box (
IdBox varchar(40) not null primary key,
BoxTittle varchar (150) not null unique,
BoxDescription varchar (max),
Height float not null,
Long float not null,
Width float not null,
Volume float not null,
MaxWeight float not null
);


create table ImageBox (
IdImageBox varchar (40) not null primary key,
IdBox varchar (40) not null,
IdImageFile varchar (40) not null,
Constraint Fk_ImageBox_IdBox foreign key (IdBox) references Box (IdBox),
Constraint Fk_ImageBox_IdImageFile foreign key (IdImageFile) references ImageFile (IdImageFile)
);

create table WareHouseBox (
IdWareHouse varchar (40) not null,
IdBox varchar (40) not null,
Stock varchar (40) not null default (0) check (Stock>=0),
Constraint Fk_WareHouse_IdWareHouse foreign key (IdWareHouse) references WareHouse (IdWareHouse),
Constraint Fk_WareHouse_IdBox foreign key (IdBox) references Box (IdBox)
);


create table BoxBarCode (
IdBoxBarCode varchar (40) primary key not null,
IdBox varchar (40) not null unique,
IdBarCode varchar(40) not null unique ,


);


