use BookStore;

create table Schedule (
IdSchedule varchar (40) primary key not null, 
YearValue int not null , -- 2012
CreateDate datetime not null,  -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,  -- 12/05/2021 12:45:00
StatusCode int not null -- 2
);

create table ScheduleLine (
IdScheduleLine varchar (40) primary key not null,
IdSchedule varchar(40) not null, -- 
MonthNum int not null check(MonthNum>0 and MonthNum<13), -- 12 
MonthDay int  check(MonthDay>0 and MonthDay<32), -- 2
IsClosed bit not null default (0),
StartTime TIME , -- 10:00 
BreakStar TIME ,  -- 14:30
BreakEnd Time , -- 15 :30
EndTime TIME , -- 20 :00
CreateDate datetime not null,  -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,  -- 12/05/2021 12:45:00
StatusCode int not null, --2
Constraint Fk_ScheduleLine_IdSchedule foreign key (IdSchedule) references Schedule (IdSchedule),
);



create table StoreSchedule (
IdSchedule varchar (40) not null primary key,
IdStore varchar (40) not null ,
Constraint Fk_StoreSchedule_IdEmployee foreign key (IdSchedule) references Schedule (IdSchedule),
Constraint Fk_StoreSchedule_IdStore foreign key (IdStore) references Store (IdStore)
);

create table EmployeeSchedule (
IdSchedule varchar (40) not null primary key,
IdEmployee varchar (40) not null 
);
alter table EmployeeSchedule add Constraint Fk_EmployeeSchedule_IdEmployee foreign key (IdSchedule) references Schedule (IdSchedule);
alter table EmployeeSchedule add Constraint Fk_EmployeeSchedule_IdStore foreign key (IdEmployee) references Employee (IdPerson);

create table WareHouseSchedule (
IdSchedule varchar (40) not null primary key,
IdWareHouse varchar (40) not null ,
Constraint Fk_WareHouseSchedule_IdEmployee foreign key (IdSchedule) references Schedule (IdSchedule),
Constraint Fk_WareHouseSchedule_IdWareHouse foreign key (IdWareHouse) references WareHouse (IdWareHouse)
);


