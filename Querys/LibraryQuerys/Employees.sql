use BookStore;



create table Person (
IdPerson varchar(40) primary key not null,
NamePerson varchar(75) not null, --- RObeert
LastName1 varchar (75) not null, -- Gonzales 
LastName2 varchar(75) , --Guitieres
Email varchar (85) not null unique, -- Roberto@gmail.com	
Phone varchar (15) not null unique, -- 756586856
Pass varchar (25) not null, -- RobertoLoquitllo 65
Dni varchar (15) not null unique, -- 98569596
TypePerson int not null default (0), -- Socie 
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,-- 12/05/2021 12:45:00
StatusCode int not null -- 1
);


create table Socie (
IdPerson varchar(40) not null primary key not null, 
Discount float  not null, -- 10,45 € 
RegisterDate datetime not null,  -- 12/05/2021 12:45:00
DesactivateDate datetime, -- 12/05/2021 12:45:00
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,-- 12/05/2021 12:45:00
StatusCode int not null -- 1
Constraint Fk_Socie_IdPerson foreign key (IdPerson) references Person (IdPerson)
);


create table Employee (
IdPerson varchar(40) not null primary key not null, 
IdBoss varchar (40) , --- 5655665 656
IdOccupation varchar (40) not null,
StartDate datetime not null, -- 12/05/2021 12:45:00
HireDate datetime  not null,  -- 12/05/2021 12:45:00
DischargeDate datetime, -- 12/05/2021 12:45:00
TypeStatus int ,--Hired,Dismiss ,Discharge 
Discount float not null, --12,5 
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,-- 12/05/2021 12:45:00
StatusCode int not null, -- 1
Constraint Fk_Employee_IdBoss foreign key(IdBoss) references Employee (IdPerson),
Constraint Fk_Employee_IdPerson foreign key (IdPerson) references Person (IdPerson),
Constraint Fk_Employee_IdOccupation foreign key (IdOccupation) references Occupation (IdOccupation),
);




create table EmployeeRol (
IdEmployee varchar (40) not null,
IdRol varchar (40) not null,
Constraint Pk_EmployeeRol Primary key(IdEmployee,IdRol),
Constraint Fk_EmployeeRol_IdRol foreign key (IdRol) references Rol (IdRol),
Constraint Fk_EmployeeRol_IdEmployee foreign key (IdEmployee) references Employee (IdEmployee)
);

create table EmployeeImageFile (
IdEmployee varchar (40) not null Primary key, -- GH56HG67GHGG56756
IdImageFile varchar (40) not null , -- GH56HG67GHGG56756
Constraint Fk_EmployeeImageFile_IdEmployee foreign key (IdEmployee) references Employee (IdEmployee),
Constraint Fk_EmployeeImageFile_IdImageFile foreign key (IdImageFile) references ImageFile (IdImageFile)
);

