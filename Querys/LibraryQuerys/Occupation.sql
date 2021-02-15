Use BookStore;
create table Occupation (
IdOccupation varchar (40) primary key not null,
OcupationName varchar (40) not null,
OcupationDescription varchar (max) ,
Salary float not null check (Salary>=0) default (0),
PayNormalHours float not null check (PayNormalHours>=0 ) default (0), -- 2,34  5.67 €
PayExtraHours float not null check (PayExtraHours>=0) default (0), -- 3.45
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,-- 12/05/2021 12:45:00
StatusCode int not null -- 1
);


