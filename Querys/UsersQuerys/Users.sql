
Use ApiUsers;
create table Users (
IdUser int identity(1,1) not null primary key,
Username varchar (50) not null,
PassWord varchar (50) not null
);