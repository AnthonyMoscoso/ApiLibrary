use BookStore;
alter table Reservation add constraint Fk_Reservation_IdEmployee foreign key (IdEmployee) references Employee (IdPerson);
alter table Reservation add Constraint Fk_Reservation_IdBuyer foreign key (IdBuyer) references Person (IdPerson);

create table Reservation (
IdReservation varchar (40) not null primary key,
IdStore varchar (40) not null,
IdEmployee varchar (40),
IdBuyer varchar (40),
ReservationStatus int not null,
FinishReservationDate datetime ,
Note varchar (max),
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null, -- 1 ,
IdBook varchar (40) not null,
Quantity int not null  check(Quantity>=1) default(1),
BookReservationPrice float not null check(BookReservationPrice>=0) default(0),
Constraint Fk_Reservation_IdStore foreign key (IdStore) references Store (IdStore),
Constraint Fk_Reservation_IdEmployee foreign key (IdEmployee) references Employee (IdPerson),
Constraint Fk_Reservation_IdBuyer foreign key (IdBuyer) references Person (IdPerson),
Constraint Fk_Reservation_IdBook foreign key (IdBook) references Book (IdBook)
);


create table ReservationSale (
IdReservation varchar (40) not null primary key,
IdSale varchar (40) not null,
Constraint Fk_ReservationSale_IdReservation foreign key (IdReservation) references Reservation (IdReservation),
Constraint Fk_ReservationSale_IdSale foreign key (IdSale) references Sale (IdSale)
);






