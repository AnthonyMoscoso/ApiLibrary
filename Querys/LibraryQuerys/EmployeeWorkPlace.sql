use BookStore;
drop table EmployeeStore;
drop table EmployeeWareHouse;

create table EmployeeStore(
IdEmployee varchar(40) not null primary key,
IdStore varchar(40) not null
);

alter table EmployeeStore add Constraint Fk_EmployeeStore_IdEmployee foreign key(IdEmployee) references Employee (IdPerson);
alter table EmployeeStore add Constraint Fk_EmployeeStore_IdStore foreign key(IdStore) references Store (IdStore);

create table EmployeeWareHouse (
IdEmployee varchar(40) not null primary key,
IdWareHouse varchar(40) not null
);

alter table EmployeeWareHouse add Constraint Fk_EmployeeWareHouse_IdEmployee foreign key(IdEmployee) references Employee (IdPerson);
alter table EmployeeWareHouse add Constraint Fk_EmployeeWareHouse_IdStore foreign key(IdWareHouse) references WareHouse (IdWareHouse);