use BookStore;
create table Direction (
IdDirection varchar (40) not null primary key, -- 00495094054
Country varchar (300) not null,
Poblation varchar (75) not null, --Collado Villalba
PostalCode varchar (10) not null, --28400
DirectionValue varchar(225) not null,-- C/Isla de la toja 12 esc drch bj c 
Details varchar (75),
Latitude nvarchar (500) not null,
Lenghth nvarchar (500) not null,
CreateDate datetime not null, --- 12/05/2021 12:45:00
LastUpdateDate datetime not null, --- 12/05/2021 12:45:00
StatusCode int not null --1 
);