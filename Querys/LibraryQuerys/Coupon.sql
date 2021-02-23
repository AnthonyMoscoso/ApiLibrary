use BookStore;
create table Coupon (
IdCoupon varchar (40) primary key not null,
CouponCode varchar (15) not null, -- 5678898
StartOffert datetime not null, --12/07/2019
FinishOffert datetime , --12/07/2019
TypeCoupon int not null, -- porcentaje , money
CouponValue int not null, -- 10 ,20,4.56
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null -- 1 
);

create table SaleCoupon (
IdSale varchar (40) not null primary key ,
IdCoupon varchar (40) not null,
Constraint Fk_SaleCoupon_IdSale foreign key (IdSale) references Sale (IdSale),
Constraint Fk_SaleCoupon_IdCoupon foreign key (IdCoupon) references Coupon (IdCoupon)
);

