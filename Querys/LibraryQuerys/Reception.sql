use BookStore;

delete from ReceptionLine;
delete from Reception;
drop table ReceptionLine;
drop table Reception;


create table Reception (
IdReception varchar(40) not null primary key,
IdEmployee varchar (40) not null,
IdStore varchar (40) not null,
CreateDate datetime not null default(GetDate()),
LastUpdateDate datetime not null default(GetDate()),
StatusCode int not null
);

alter table Reception add constraint Fk_Reception_IdEmployee 
foreign key (IdEmployee) references Employee (IdPerson);


alter table Reception add constraint Fk_Reception_IdStore 
foreign key (IdEmployee) references Store (IdStore);

create table ReceptionLine (
IdReceptionLine varchar (40) not null primary key,
IdReception varchar (40) not null,
IdBook varchar (40) not null,
Quantity int not null default (1),
CreateDate datetime not null default(GetDate()),
LastUpdateDate datetime not null default(GetDate()),
StatusCode int not null
);

alter table ReceptionLine add constraint  Fk_ReceptionLine_IdReception 
foreign key (IdReception) references Reception (IdReception);

alter table ReceptionLine add constraint Fk_ReceptionLine_IdBook 
foreign key (IdBook) references Book (IdBook);

create table ReceptionOrder (
IdOrder varchar (40) not null ,
IdReception varchar (40) not null unique
);

alter table ReceptionOrder 
add constraint Pk_OrderReception 
primary key (IdOrder,IdReception);

alter table ReceptionOrder 
add constraint Fk_OrderReception_IdOrder
foreign key (IdOrder) references Orders (IdOrder);

alter table ReceptionOrder 
add constraint Fk_OrderReception_IdReception
foreign key (IdReception) references Reception (IdReception);

create table ReceptionPurchase (
IdPurchase varchar (40) not null ,
IdReception varchar (40) not null unique
);

alter table ReceptionPurchase
add constraint Pk_ReceptionPurchase 
primary key (IdPurchase,IdReception);

alter table ReceptionPurchase 
add constraint Fk_ReceptionPurchase_IdPurchase
foreign key (IdPurchase) references Purchase (IdPurchase);

alter table ReceptionPurchase 
add constraint Fk_ReceptionPurchase_IdReception
foreign key (IdReception) references Reception (IdReception);