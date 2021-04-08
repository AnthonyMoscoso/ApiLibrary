use BookStore;
 alter table Sale add Constraint Fk_Sale_IdBuyer foreign key (IdBuyer) references Person (IdPerson);
 alter table Sale add Constraint Fk_Sale_IdSeller foreign key (IdSeller) references Employee (IdPerson)

create table Sale (
IdSale varchar(40) primary key not null, -- GH56HG67GHGG56756
IdBuyer varchar(40) , -- 5667676 7
IdSeller varchar(40), --6 767 67 676
Total float not null check(Total>=0),
Discount float not null default (0), -- 12.67
SaleStatus int not null, -- 1
PayMethod int not null, --1
TotalWithIva float not null,
Iva float not null,
MoneyPaid float not null default (0) check (MoneyPaid>=0), -- 2.3455
MoneyReturned float not null default (0) check(MoneyReturned>=0), -- 45.67
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null, -- 1 
Constraint Fk_Sale_IdBuyer foreign key (IdBuyer) references Person (IdPerson),
Constraint Fk_Sale_IdSeller foreign key (IdSeller) references Employee (IdPerson)
);

/*
create table OnlineSale (
IdOnlineSale varchar(40) primary key not null , -- GH56HG67GHGG56756
IdSale varchar (40) unique not null, -- GH56HG67GHGG56756

IdShipping varchar (40) not null, -- GH56HG67GHGG56756
Constraint Fk_OnlySale_IdSale foreign key (IdSale) references Sale (IdSale),
Constraint Fk_OnlySale_IdShipping foreign key (IdShipping) references Shipping (IdShipping)
);
*/
create table SaleLine (
IdSaleLine varchar (40) primary key not null, -- GH56HG67GHGG56756
IdSale varchar(40) not null, -- GH56HG67GHGG56756
IdBook varchar(40) not null, -- GH56HG67GHGG56756
Price float not null check (Price>=0) default (0), --34.56
Discount float not null check (Discount>=0) default (0), --3.45
Quantity int not null check(Quantity>=1), --56.78
StatusLine int, --Normal,Cancel,Devolucion
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,-- 12/05/2021 12:45:00
StatusCode int not null, -- 1
Constraint Fk_SaleLine_IdBook foreign key (IdBook)  references Book (IdBook),
Constraint Fk_SaleLine_IdSale foreign key (IdSale)  references Sale (IdSale)
);

create table StoreSale (
IdStore varchar (40) not null,
IdSale varchar (40) not null primary key
Constraint Fk_StoreSale_IdStore foreign key (IdStore)  references Store (IdStore),
Constraint Fk_StoreSale_IdSale foreign key (IdSale)  references Sale (IdSale)
);

