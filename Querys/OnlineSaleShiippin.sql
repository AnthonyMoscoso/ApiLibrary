use BookStore;
create table OnlineSaleShipping  (
IdOnlineSale varchar (40) not null,
IdShipping varchar (40) not null
);

alter table OnlineSaleShipping add constraint 
Pk_OnlineSaleShipping primary key (IdOnlineSale,IdShipping);

alter table OnlineSaleShipping 
add constraint Fk_OnlineSaleShipping_IdOnlineSale 
foreign key (IdOnlineSale) references OnlineSale(IdOnlineSale);

alter table OnlineSaleShipping 
add constraint Fk_OnlineSaleShipping_IdShipping 
foreign key (IdShipping) references Shipping (IdShipping);
