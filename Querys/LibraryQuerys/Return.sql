use BookStore;

create table ReturnSale (
IdReturn varchar (40) primary key not null, -- GH56HG67GHGG56756
IdSale varchar (40) not null, -- GH56HG67GHGG56756
Repayment float not null, -- 4.56
RepaymentMethod int not null, -- Efective 
RepaymentStatus int not null , -- Cancel
ReturnMotive varchar (50) not null,
ReturnDescription varchar (max) ,
Note varchar(max),
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null, -- 1
Constraint Fk_SaleReturn_IdSale foreign key (IdSale) references Sale (IdSale)
);


create table ReturnLine (
IdReturnLine varchar (40) primary key not null,
IdReturn varchar (40) not null,
IdBook varchar (40) not null,
Quantity int not null default (1) check (Quantity>=1), -- 3
BookPrice float not null default (0) check (BookPrice>=0),
Note varchar(max),
Constraint Fk_ReturnLine_IdBook foreign key (IdBook) references Book (IdBook),
Constraint Fk_ReturnLine_IdReturn foreign key (IdReturn) references ReturnSale (IdReturn)
);



create table ReturnStore (
IdReturn varchar (40) not null primary key,
IdStore varchar (40) not null ,
Constraint Fk_ReturnStore_IdStore  foreign key (IdStore) references Store (IdStore),
Constraint Fk_ReturnStore_IdReturn foreign key (IdReturn) references ReturnSale (IdReturn)
);

create table ReturnWareHouse (
IdReturn varchar (40) not null primary key,
IdWareHouse varchar (40) not null ,
Constraint Fk_ReturnnWareHouse_IdStore  foreign key (IdWareHouse) references WareHouse (IdWareHouse),
Constraint Fk_ReturnnWareHouse_IdReturn foreign key (IdReturn) references ReturnSale (IdReturn)
);*/

