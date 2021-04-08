use BookStore;


create table SickLeave (
IdSickLeave  varchar (40) primary key not null, -- 54656jhj6hj5h6
IdEmployee varchar (40) not null, -- 453454 534fdgfd g
StartDate datetime not null,  -- 12/05/2021 12:45:00
EndDate datetime ,  -- 12/05/2021 12:45:00
Reason varchar (75) not null, --- Enfermedad 
Details  varchar (max), --- dsjfkjdskfsdfgfsdfjgkfjdkgjsdkjkgsdkdgs
SickLeaveStatus int not null, --
IdDocument varchar(40), -- 4954398593489
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,-- 12/05/2021 12:45:00
StatusCode int not null, -- 1

);

alter table SickLeave add Constraint Fk_SickLeave_IdEmployee foreign key (IdEmployee) references Employee (IdPerson);
alter table SickLeave add Constraint Fk_SickLeave_IdDocument foreign key (IdDocument) references DocumentFile (IdDocument);