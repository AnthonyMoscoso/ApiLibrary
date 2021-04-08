use BookStore;
create table Box (
IdBox varchar(40) primary key not null,
BoxName varchar(120) not null,
Material varchar(80),
MaxWeight  float not null default(0),
Width float not null default(0),
Height float not null default(0),
Length float not null default(0),
Volume float not null default(0),
CreateDate datetime not null default(GetDate()),
LastUpdate datetime not null default(GetDate()),
StatusCode int not null default(0)
);


alter table Box add constraint Check_MaxWeight Check (MaxWeight>=0);
alter table Box add constraint Check_Width Check (Width>=0);
alter table Box add constraint Check_Height Check (Height>=0);
alter table Box add constraint Check_Length Check (Length>=0);