use BookStore;
create table Rol (
IdRol varchar(40)primary key not null,
RolName varchar (35) unique, --- Dependiente 
RolDescription varchar (max) not null, -- DJSDDJGHJDFHJGHDFJGHJHGJSDG
CreateDate datetime not null,  -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,  -- 12/05/2021 12:45:00
StatusCode int not null -- 2
);

create table Permit (
IdPermit varchar (40) primary key not null, -- GH56HG67GHGG56756
PermitName varchar (75) not null unique,  -- Venta 
PermitDescription varchar (max), --- sdfdsf dsd fsdf 
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,-- 12/05/2021 12:45:00
StatusCode int not null -- 1
);

create table RolPermit (
IdRol varchar (40) not null, -- GH56HG67GHGG56756
IdPermit varchar (40) not null, -- GH56HG67GHGG56756
Constraint Pk_RolPermit primary key (IdRol,IdPermit),
Constraint Fk_RolPermit_IdRol foreign key (IdRol) references Rol(IdRol),
Constraint Fk_RolPermit_IdPermit foreign key (IdPermit) references Permit (IdPermit),
);
