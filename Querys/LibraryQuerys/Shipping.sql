use BookStore;
create table Shipping (
IdShipping varchar (40) primary key not null, -- GH56HG67GHGG56756
IdDirectionFrom varchar (40) not null,
IdDirectionTo varchar (40) not null, -- GH56HG67GHGG56756
ShippingPrice float check(ShippingPrice>=0) default (0), -- 6,56
DepartureDate datetime not null, -- 12/05/2021 12:45:00
ExpectArrivalDate datetime , -- 12/05/2021 12:45:00
ArrivalDate datetime , -- 12/05/2021 12:45:00
ShippingStatus int not null,  -- 2 
Note varchar(max),
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null, -- 1 
Constraint Fk_Shipping_IdDirectionFrom foreign key (IdDirectionFrom) references Direction (IdDirection),
Constraint Fk_Shipping_IdDirectionTo foreign key (IdDirectionTo) references Direction (IdDirection)
);


create table ShippingLine (
IdShippingLine varchar (40) primary key not null,
IdShipping varchar (40) not null,
IdBook varchar (40) not null,
Quantity  int not null Check (Quantity>=1) default (1),
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null, -- 1 
Constraint Fk_ShippingLine_IdShipping foreign key (IdShipping) references Shipping (IdShipping),
Constraint Fk_ShippingLine_IdBook foreign key (IdBook) references Book (IdBook)
);

