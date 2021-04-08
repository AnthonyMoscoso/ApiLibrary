Use BookStore;
--Compra
create table Purchase (
IdPurchase varchar (40) primary key not null,
IdEditorial  varchar (40) not null,
IdEmployee varchar (40) not null,
PurchaseStatus int not null,
Total float not null check (Total>=0) default (0),
ExpectArrivalDate datetime , -- 12/05/2021 12:45:00
ArrivalDate datetime , -- 12/05/2021 12:45:00
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null -- 1 
);

alter table Purchase add Constraint Fk_Purchase_IdEmployee foreign key (IdEmployee) references Employee (IdPerson);
alter table Purchase add Constraint Fk_Purchase_IdEditorial foreign key (IdEditorial) references Editorial (IdEditorial) ;


create table PurchaseLine (
IdPurchaseLine varchar (40) primary key not null,
IdPurchase varchar (40) not null,
IdBook varchar (40) not null,
BookPurchasePrice float not null check (BookPurchasePrice>=0) default (0),
Quantity int not null check (Quantity>=1) default (1),
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null, -- 1 
Constraint Fk_PurchaseLine_IdPurchase foreign key (IdPurchase) references Purchase (IdPurchase),
Constraint Fk_PurchaseLine_IdBook foreign key (IdBook) references Book (IdBook)
);


create table PurchaseStore (
IdPurchase varchar(40) not null primary key ,
IdStore  varchar (40) not null,
Constraint Fk_PurchaseStore_IdStore foreign key (IdStore) references Store (IdStore),
Constraint Fk_PurchaseStore_IdPurchase foreign key (IdPurchase) references Purchase (IdPurchase)
);


create table PurchaseWareHouse (
IdPurchase varchar(40) not null primary key,
IdWareHouse  varchar (40) not null,
Constraint Fk_PurchaseWareHouse_IdStore foreign key (IdWareHouse) references WareHouse (IdWareHouse),
Constraint Fk_PurchaseWareHouse_IdPurchase foreign key (IdPurchase) references Purchase (IdPurchase)
);