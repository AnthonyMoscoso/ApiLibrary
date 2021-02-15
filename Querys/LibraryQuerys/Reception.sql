use BookStore;
create table Reception(
IdReception varchar (40) not null primary key,
IdEmployee varchar (40) not null,
IdStore varchar (40) not null,
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null ,-- 1 
Constraint Fk_Reception_IdEmployee foreign key (IdEmployee) references Employee (IdEmployee),
Constraint Fk_Reception_IdStore foreign key (IdStore) references Store (IdStore)
);


create table ReceptionLine (
IdReceptionLine varchar (40) not null primary key,
IdReception varchar (40) not null,
IdShipping varchar (40) not null,
IdBook varchar (40) not null,
Quantity int not null check(Quantity>=1) default(1),
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null -- 1 
Constraint Fk_ReceptionLine_IdReception foreign key (IdReception) references Reception (IdReception),
Constraint Fk_ReceptionLine_IdShipping foreign key (IdShipping) references Shipping (IdShipping),
Constraint FK_ReceptionLine_IdWareHouse foreign key (IdBook) references Book (IdBook)
);