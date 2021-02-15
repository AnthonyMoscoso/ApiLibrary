use BookStore;


create table Register(
IdRegister varchar (40) not null primary key,
RegisterDate datetime not null ,
CreateDate datetime not null,  -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,  -- 12/05/2021 12:45:00
StatusCode int not null -- 2
);

create table RegisterLine (
IdRegisterLine varchar (40) not null primary key ,
IdRegister varchar (40) not null, -- 4
IdEmployee varchar (40) not null, -- 2  ,2 
EnterHour time , -- 3 ,10
ExistHoure time, -- 8 , 15
CreateDate datetime not null,  -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,  -- 12/05/2021 12:45:00
StatusCode int not null ,-- 2
Constraint Fk_RegisterLine_IdRegister foreign key (IdRegister) references Register(IdRegister),
Constraint Fk_RegisterLine_IdEmployee foreign key (IdEmployee) references Employee(IdEmployee)
);

create table RegisterStore (
IdStore varchar (40) not null,
IdRegister varchar (40) not null primary key ,
Constraint Fk_RegisterStore_IdStore foreign key (IdStore) references Store(IdStore),
Constraint Fk_RegisterStore_IdRegister foreign key (IdRegister) references Register(IdRegister)
);