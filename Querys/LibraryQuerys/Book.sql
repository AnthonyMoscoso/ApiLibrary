use BookStore;
-- Tipo de libros , Comic , Libro , Revistas , Manga,Novelas ---

create table BookType (
IdType varchar (40) not null primary key, -- kjhkfg56u9t9rf
IdFather varchar (40), -- iud5868rf8g54
TypeName varchar (75) not null unique, -- Comic
TypeDescription varchar(max) not null, -- 
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null, -- 1
Constraint Fk_BookType_IdFather foreign key  (IdFather) references BookType (IdType)
);


create table Edition (
IdEdition varchar (40) primary key not null,
EditionName varchar (125) not null unique,
EditionDescription varchar (max) not null,
CreateDate datetime not null, -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null -- 1
);


create table Autor (
IdAutor varchar (40) not null primary key,
AutorName varchar (135) not null unique, -- Stephen King 
CreateDate datetime not null, --- 5465656456
LastUpdateDate datetime not null, --- 5465656456
StatusCode int not null -- 2
);



--- Accion , romance , Fantasia ...
create table Gender  (
IdGender  varchar (40) not null primary key, ---6767 6767
GenderName varchar (75) unique not null, -- Romance 
GenderDescription varchar (max) not null, -- dfksdfkjsdfsdfksd 
CreateDate datetime not null,   -- 12/05/2021 12:45:00
LastUpdateDate datetime not null,  -- 12/05/2021 12:45:00
StatusCode int not null --1 
);

create table Book (
IdBook varchar (40) primary key not null, --- 676767 
IdType varchar (40) not null , -- kkjj54654
IdEdition varchar (40) not null ,
BookTittle varchar (135) not null, -- Los angel 
Languages varchar (75), -- Ingles
PublicationDate datetime not null,
Pags int not null default (1) check(Pags>=1),
ISBM varchar (25) not null unique,
EditionNum int not null default (1) check (EditionNum>=1),
Synopsis varchar (max) not null,
BindingType int not null ,
Price float not null,
CreateDate datetime not null,  -- 12/05/2021 12:45:00
LastUpdateDate datetime not null, -- 12/05/2021 12:45:00
StatusCode int not null ,-- 2
Constraint Fk_Book_IdType foreign key (IdType) references BookType (IdType),
Constraint Fk_Book_IdEdition foreign key (IdEdition) references Edition (IdEdition),
);


create table BookStore (
IdBookStore varchar (40) primary key not null,
IdBook varchar (40) not null,
IdStore varchar (40) not null,
BookPrice float not null check(BookPrice>=0) default (0),
Stock int not null check (Stock>=0) default(0),
Constraint Fk_BookStore_IdBook foreign key (IdBook) references Book(IdBook),
Constraint Fk_BookStore_IdStore foreign key (IdStore) references Store (IdStore)
);

create table BookEditorial (
IdBookEditorial varchar (40) primary key not null,
IdBook varchar(40) not null,
IdEditorial varchar (40) not null,
PurchasePrice float not null default (0),
IsDiscontinued bit not null ,
Constraint Fk_BookEditorial_IdBook foreign key (IdBook) references Book(IdBook),
Constraint Fk_BookEditorial_IdEditorial foreign key (IdEditorial) references Editorial (IdEditorial)
);


create table BookImageFile (
IdBook varchar (40)  not null primary key not null, -- GH56HG67GHGG56756
IdImageFile varchar (40) not null, -- GH56HG67GHGG56756
Constraint Fk_BookImageFile_IdBook foreign key (IdBook) references Book (IdBook),
Constraint Fk_BookImageFile_IdImageFile foreign key (IdImageFile) references ImageFile (IdImageFile)
);
create table BookAutor (
IdBook varchar(40) not null, -- 65_5657676FGF
IdAutor varchar (40) not null,-- FDGJ54654656
Constraint PK_BookAutor primary key (IdBook,IdAutor),
Constraint Fk_BookAutor_IdBook foreign key (IdBook) references Book (IdBook),
Constraint Fk_BookAutor_IdAutor foreign key (IdAutor) references Autor (IdAutor)
);


create table BookGender (
IdBook varchar(40) not null, --- 5465656456
IdGender varchar(40) not null, --ujrfut5u645
Constraint PK_BookGender primary key (IdBook,IdGender),
Constraint Fk_BookGender_IdBook foreign key (IdBook) references Book (IdBook),
Constraint Fk_BookGender_IdGender foreign key (IdGender ) references Gender  (IdGender )
);



create table WareHouseBook (
IdWareHouseBook varchar (40) not null primary key ,
IdWareHouse varchar (40) not null,
IdBook varchar (40) not null,
Stock int not null default (0) check (Stock>=0),
Constraint Fk_WareHouseBook_IdWareHouse foreign key(IdWareHouse) references WareHouse  (IdWareHouse),
Constraint Fk_WareHouseBook_IdBook foreign key(IdBook) references Book  (IdBook)
);

create table Barcode (
IdBarcode varchar (40) primary key not null,
IdImageFile varchar (40) not null unique,
IdBook varchar (40) not null unique,
Constraint Fk_Barcode_IdImageFile foreign key (IdImageFile) references ImageFile (IdImageFile),
Constraint Fk_Barcode_IdBook foreign key (IdBook) references  Book(IdBook)
);