create table PaymentBonus (
IdPaymentBonus varchar (40) not null primary key ,
BonusTittle varchar (75) not null ,
BonusType int not null,
BonusValue float not null check (BonusValue>=1) default (1),
BonusDescription varchar (max),
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,-- 12/05/2021 12:45:00
StatusCode int not null -- 1
);


create table PaymentBonusOccupation (
IdPaymentBonus  varchar (40) not null,
IdOccupation varchar (40) not null,
Constraint Pk_PaymentBonusOccupation primary key(IdPaymentBonus,IdOccupation) ,
Constraint Fk_PaymentBonusOccupation_IdPaymentBonus foreign key (IdPaymentBonus) references PaymentBonus (IdPaymentBonus),
Constraint Fk_PaymentBonusOccupation_IdOcuppation foreign key (IdOccupation) references Occupation (IdOccupation)

);


create table PaymentBonusEmployee (
IdPaymentBonus  varchar (40) not null,
IdEmployee varchar (40) not null,
Constraint Pk_PaymentBonusEmployee primary key (IdPaymentBonus,IdEmployee),
Constraint Fk_PaymentBonusEmployee_IdPaymentBonus foreign key (IdPaymentBonus) references PaymentBonus (IdPaymentBonus),
Constraint Fk_PaymentBonusEmployee_IdEmployee foreign key (IdEmployee) references Employee (IdEmployee)

);