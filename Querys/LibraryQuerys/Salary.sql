use BookStore;

create table Taxes (
IdTaxes varchar (40) primary key not null,
TaxTittle varchar (75) not null unique,
TaxDescription varchar (max),
TaxType int not null,
TaxValue float  not null,
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,-- 12/05/2021 12:45:00
StatusCode int not null -- 1
);

create table PayRoll (
IdPayRoll varchar (40)  primary key not null,
IdEmployee varchar (40) not null,
YearValue int not null, -- 2020
MonthNum int not null check(MonthNum>0 and MonthNum<13), -- 11
NormalHourWorkers float not null check(NormalHourWorkers>=0) default (0),
ExtraHourWorkers float not null check(ExtraHourWorkers>=0) default (0),
PayNormalHours float not null check (PayNormalHours>=0 ) default (0), -- 2,34  5.67 €
PayExtraHours float not null check (PayExtraHours>=0) default (0), -- 3.45
ExtraTotal float not null check (ExtraTotal>=0) default (0), -- 200 
TotalGross float not null default (0) check(TotalGross>=0), -- 1678.90 €
TotalNet float not null default (0) check(TotalNet>=0 ), -- 1678.90 €
TaxesTotal int not null check (TaxesTotal>=0) default (0),
PayDate datetime not null,
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,-- 12/05/2021 12:45:00
StatusCode int not null -- 1
);

alter table PayRoll add constraint Fk_PayRoll_Employee foreign key (IdEmployee)  references Employee(IdPerson);

create table PayRollTaxes (
IdPayRoll varchar (40) not null,
IdTaxes varchar (40) not null,
Constraint Pk_PayRollTaxes primary key(IdTaxes ,IdPayRoll) ,
Constraint Fk_PayRollTaxes_IdPaymentBonus foreign key (IdTaxes ) references Taxes  (IdTaxes ),
Constraint Fk_PayRollTaxes_IdOcuppation foreign key (IdPayRoll) references PayRoll (IdPayRoll)


);

create table PayRollBonus (
IdPaymentBonus varchar (40) not null,
IdPayRoll varchar (40) not null,
Constraint Pk_PayRollBonus primary key(IdPaymentBonus,IdPayRoll) ,
Constraint Fk_PayRollBonus_IdPaymentBonus foreign key (IdPaymentBonus) references PaymentBonus (IdPaymentBonus),
Constraint Fk_PayRollBonus_IdPayRoll foreign key (IdPayRoll) references PayRoll (IdPayRoll)
)


create table PayRollStore(
IdStore varchar (40) not null,
IdPayRoll varchar (40) not null,
Constraint Pk_PayRollStore primary key(IdStore,IdPayRoll) ,
Constraint Fk_PayRollStore_IdStore foreign key (IdStore) references Store (IdStore),
Constraint Fk_PayRollStore_IdPayRoll foreign key (IdPayRoll) references PayRoll (IdPayRoll)
)


