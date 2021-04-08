

use BookStore;
create table OnlineSale (
IdOnlineSale varchar(40) primary key not null,
ShippingPrice float not null default(0)
);

alter table OnlineSale add constraint Ck_ShippingPrice check (ShippingPrice>=0);
alter table OnlineSale 
add constraint Fk_OnlineSale_Sale
foreign key(IdOnlineSale) references Sale(IdSale);




