use BookStore;
drop table BookDiscount;
drop table Discount;
create table Discount (
IdDiscount varchar (40) primary key not null, -- GH56HG67GHGG56756
TypeDiscount int , -- Porcentaje,Total ,
StartDate datetime not null,
EndDate datetime,
DiscountValue float not null,-- 12%
DiscountStatus int not null,-- Desactivate, Activate,
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null, -- 1 
);


create table BookDiscount (
IdBook varchar (40) not null primary key ,
IdDiscount varchar (40) not null ,
Constraint Fk_BookDiscount_IdBook foreign key (IdBook) references Book (IdBook),
Constraint Fk_BookDiscount_IdDiscount foreign key (IdDiscount) references Discount (IdDiscount));



