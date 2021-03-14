
drop table ReservationLine;
alter table Reservation add  IdBook varchar (40) not null;
alter table Reservation add  Quantity int  not null check(Quantity>=1) default(1);
alter table Reservation add IdPerson varchar (40) not null;
alter table Reservation add BookReservationPrice float not null default(0) check (BookReservationPrice>=0);
alter table Reservation add Constraint Fk_Reservation_IdBook foreign key (IdBook) references Book (IdBook);
alter table Reservation add Constraint Fk_Reservation_IdPerson foreign key (IdPerson) references Person (IdPerson);

