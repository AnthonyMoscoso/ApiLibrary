use BookStore;
create table EmployeeStore(
IdEmployee varchar(40) not null primary key,
IdStore varchar(40) not null,
Constraint Fk_EmployeeStore_IdEmployee foreign key(IdEmployee) references Employee (IdEmployee),
Constraint Fk_EmployeeStore_IdStore foreign key(IdStore) references Store (IdStore)
);

create table EmployeeWareHouse (
IdEmployee varchar(40) not null primary key,
IdWareHouse varchar(40) not null,
Constraint Fk_EmployeeWareHouse_IdEmployee foreign key(IdEmployee) references Employee (IdEmployee),
Constraint Fk_EmployeeWareHouse_IdStore foreign key(IdWareHouse) references WareHouse (IdWareHouse)
);