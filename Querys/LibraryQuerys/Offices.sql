use BookStore;

create table WareHouse (
IdWareHouse varchar (40) primary key not null,
IdDirection varchar (40) not null,
WareHouseName varchar (125) not null , -- Tint Hitn Sl. AS 
WareHouseDescription varchar (max) not null,
Phone varchar (15) not null unique, --675894094
Email varchar (75) not null unique, -- Hint@gmail.com		
Web varchar (75) not null unique, --- HintEnterprise.com 
Note varchar (max) ,
CreateDate datetime not null, --- 12/05/2021 12:45:00
LastUpdateDate datetime not null,--- 12/05/2021 12:45:00
StatusCode int not null ,-- 
Constraint Fk_WareHouse_IdDirection foreign key (IdDirection) references Direction (IdDirection)
);

create table Store (
IdStore varchar (40) not null primary key , -- 78JGUUITY567
IdDirection  varchar (40) not null,  -- 78JGUUITY567
StoreName varchar (125) not null , -- Tint Hitn Sl. AS 
StoreDescription varchar (max) not null,
Phone varchar (15) not null unique, -- 675894094
Email varchar (75) not null unique, -- Hint@gmail.com		
Web varchar (75) not null unique, --- HintEnterprise.com 
Note varchar (max),
CreateDate datetime not null, --- 12/05/2021 12:45:00
LastUpdateDate datetime not null,--- 12/05/2021 12:45:00
StatusCode int not null ,--
Constraint Fk_Store_IdDirection foreign key (IdDirection) references Direction (IdDirection)
);


--Provedores de productos 

create table Editorial (
IdEditorial varchar (40) primary key not null, --45456564564
IdDirection varchar (40) not null unique, --4564546546
IdEditorialFather varchar (40),
EditorialName varchar (125) not null unique, -- Tint Hitn Sl. AS 
EditorialDescription varchar (max) not null,
Phone varchar (15) not null unique, --675894094
Email varchar (75) not null unique, -- Hint@gmail.com		
Web varchar (75) not null unique, --- HintEnterprise.com 
Note varchar (max),
CreateDate datetime not null, --- 12/05/2021 12:45:00
LastUpdateDate datetime not null,--- 12/05/2021 12:45:00
StatusCode int not null ,-- 
Constraint Fk_Editorial_IdEditorialFather  foreign key (IdEditorialFather) references Editorial (IdEditorial),
Constraint Fk_Editorial_IdDirection foreign key (IdDirection) references Direction (IdDirection)
);


create table Providers (
IdProvider  varchar (40) primary key not null,
IdDirection varchar (40)  not null,
ProviderName varchar (150) not null,
Phone varchar (15) not null,
Email varchar (75) not null ,
Web varchar (75) not null,
Note varchar (max),
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,-- 12/05/2021 12:45:00
StatusCode int not null, -- 1
Constraint Fk_Providers_IdDirection foreign key (IdDirection) references Direction (IdDirection)
);
