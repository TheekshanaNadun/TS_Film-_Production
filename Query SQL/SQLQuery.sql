Create Database QuietAtticFilms;

Create table Client(
Client_Id int,
Name varchar(50),
Contact_No int,
primary key(Client_Id)
)
Create table Production(
Production_Id int,
Name varchar(100),
Type varchar(50),
Client_Id int,
primary key(Production_Id),
foreign key(Client_Id) references Client(Client_Id),
)
Create table Location(
Location_Id int,
Name varchar(100),
Address varchar(50),
primary key(Location_Id)
)
Create table Property(
Property_Id int,
Name varchar(100),
Type varchar(50),
QTY int,
Primary key(Property_Id)
)
Create table Staff(
Staff_Id int,
Name varchar(100),
Type varchar(50),
QTY int,
Primary key(Staff_Id)
)




create table ProductionProperty(

Production_Id int,
Property_Id int,
foreign key(Production_Id) references Production(Production_Id),
foreign key(Property_Id) references Property(Property_Id),
)
create table ProductionLocation(

Location_Id int,
Production_Id int,
foreign key(Location_Id) references Location(Location_Id),
foreign key(Production_Id) references Production(Production_Id),
)

create table LocationProperty(

Property_Id int,
Location_Id int,
foreign key(Property_Id) references Property(Property_Id),
foreign key(Location_Id) references Location(Location_Id),

)

create table productionStaff(

Production_Id int,
Staff_Id int,
foreign key(Staff_Id) references Staff(Staff_Id),
foreign key(Production_Id) references Production(Production_Id),

)
