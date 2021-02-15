-- Archivos de Imagen
use BookStore;
create table ImageFile (
IdImageFile varchar (40) not null primary key , -- 00495094054
FileDir varchar (max) not null, -- /Comics/Accion/Marvel/Capitan America
ImageFileName varchar (125) not null, -- Portada1
ImageType varchar(10) not null, -- JPG
Note varchar (max), -- dfksdfd sfsdf
CreateDate datetime not null, --- 12/05/2021 12:45:00
LastUpdateDate datetime not null,--- 12/05/2021 12:45:00
StatusCode int not null --1
);



-- Archivos de documentacion , pdf ,png ,
create table DocumentFile (
IdDocument varchar (40) not null primary key , --6756756765
DocumentDir varchar (max) not null, -- -- /Documents/Bajas 
DocumentName varchar (125) not null, -- BajaEnfermedad_AntonioVIRT_23_05_2021
DocumentType varchar(10) not null, --pdf ,jpg,png 
Note varchar (max), -- 
CreateDate datetime not null, --- 12/05/2021 12:45:00
LastUpdateDate datetime not null, --- 12/05/2021 12:45:00
StatusCode int not null --1
);
