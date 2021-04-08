use BookStore;
-- Pedidos de productos 
-- Pedidos

create table Orders (
IdOrder varchar (40) not null primary key, -- GH56HG67GHGG56756
IdStore varchar (40) not null ,
IdEmployee  varchar (40) not null, -- GH56HG67GHGG56756
IdWareHouse varchar (40) not null, -- GH56HG67GHGG56756
OrderStatus int not null,
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null -- 1 
);

alter table Orders add Constraint Fk_Order_IdStore foreign key (IdStore) references Store (IdStore);
alter table Orders add Constraint Fk_Order_IdEmployee foreign key (IdEmployee) references Employee (IdPerson);
alter table Orders add Constraint FK_Order_IdWareHouse foreign key (IdWareHouse) references WareHouse (IdWareHouse);

create table OrderLine (
IdOrderLine varchar (40) primary key not null, -- GH56HG67GHGG56756
IdOrder varchar (40) not null, -- GH56HG67GHGG56756
IdBook varchar (40) not null, -- GH56HG67GHGG56756
Quantity int not null check(Quantity>=1) default(1),
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null, -- 1 
Constraint Fk_OrderLine_IdOrder foreign key (IdOrder) references Orders (IdOrder),
Constraint Fk_OrderLine_IdBook foreign key (IdBook) references Book (IdBook)
);


