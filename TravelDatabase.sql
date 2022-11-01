create database TravelDB;
use TravelDB;

Create Table UserLogin(
UserName varchar(20) NOT NULL primary Key,
Password varchar(20) NOT NULL,
EmpId varchar(20) NOT NULL,
foreign key(EmpId) references Employee(EmpId)
);

Insert Into UserLogin Values("shivam123","Shiv@1445","WGS0867");
Insert Into UserLogin Values("mohini145","Mohi@1144","WGS2255");
Insert Into UserLogin Values("pulkit876","Pul@4560","WGS9966");
Insert Into UserLogin Values("mukul432","Muk@0091","WGS2587");
Insert Into UserLogin Values("praveen670","Pra@0071","WGS1144");
Insert Into UserLogin Values("james998","Jam@0101","WGS1694");
Insert Into UserLogin Values("Tim1990","Tim@1010","WGS3366");
Insert Into UserLogin Values("shane1109","Sha@6541","WGS2022");

Create Table GCM(
GCMId int NOT NULL Primary Key,
GCM_Level Varchar(20) UNIQUE NOT NULL);

insert into GCM values (1, "GCM-1");
insert into GCM values (2, "GCM-2");
insert into GCM values (3, "GCM-3");
insert into GCM values (4, "GCM-4");

Create Table Travel(
TravelId Int NOT NULL Primary Key,
Travel_Type Varchar(20) NOT NULL UNIQUE) ;
insert into Travel values (101,"Business Travel");
insert into Travel values (102,"Short Term Travel");
insert into Travel values (103,"Long Term Travel");
insert into Travel values (104,"Permanent Relocation");


create Table Country(
CountryId varchar(20) NOT NULL Primary key,
CountryName varchar(40) NOT NULL);
insert into Country values ("IND", "India");
insert into Country values ("USA", "United States of America");
insert into Country values ("ITA", "Italy");
insert into Country values ("FRA", "France");
insert into Country values ("CUB", "Cuba");


Create Table City(
CityId Int NOT NULL Primary Key,
CityName Varchar(20) NOT NULL Unique,
CountryId varchar(20) NOT NULL,
Foreign Key (CountryId) references Country(CountryId));
insert into City values (1, "Mumbai", "IND");
insert into City values (2, "Pune", "IND");
insert into City values (3, "Nashik", "IND");
insert into City values (4, "New York", "USA");
insert into City values (5, "Chicago", "USA");
insert into City values (6, "Phoenix", "USA");
insert into City values (7, "Rome", "ITA");
insert into City values (8, "Milan", "ITA");
insert into City values (9, "Turin","ITA");
insert into City values (10, "Paris","FRA");
insert into City values (11, "Cannes", "FRA");
insert into City values (12, "Lyon", "FRA");
insert into City values (13, "Havana", "CUB");
insert into City values (14, "Bayamo","CUB");
insert into City values (15, "Holguin", "CUB");

Create Table Employee(
EmpId  varchar(20)NOT NULL Primary key,
EmpName Varchar(20) NOT NULL,
GCMId int(20) NOT NULL ,
ManagerId Varchar(20) ,
Country Varchar(20) NOT NULL,
City Varchar(20) NOT NULL,
Foreign Key (GCMId) references GCM(GCMId),
foreign key (ManagerId) references Manager(ManagerId)

);

Insert Into Employee Values("WGS0867","Shivam Sharma",4,null,"India","Mumbai");
Insert Into Employee Values("WGS2255","Mohini Karande",1,"WGS1694","India","pune");
Insert Into Employee Values("WGS9966","Pulkit Samrat",2,"WGS1694","India","Chennai");
Insert Into Employee Values("WGS2587","Mukul Singh",3,"WGS0867","India","Banglore");
Insert Into Employee Values("WGS1144","Praveen Pandey",2,"WGS0867","India","Mumbai");
Insert Into Employee Values("WGS1694","James Bond",4,null,"France","Canes");
Insert Into Employee Values("WGS3366","Tim Smoothe",3,"WGS0867","USA","New York");
Insert Into Employee Values("WGS2022","Shane Watson",2,"WGS1694","Australia","Sydney");

create table Manager(
ManagerId varchar(20) NOT NULL Primary key,
ManagerName varchar(20) NOT NULL,
DadId varchar(20) Not null,
Password varchar(20) not null);

Insert into Manager values("WGS1694", "James Bond", "W147896", "jame@123");
Insert into Manager values("WGS0867", "Shivam Sharma", "W258741", "shiv@123");




Create Table Travelers(
Request_No Int NOT NULL Auto_Increment Primary Key,
EmpId Varchar(20) NOT NULL,
GCMId Int NOT NULL,
TravelId int NOT NULL ,
CountryId Varchar(20) NOT NULL,
CityId int NOT NULL,
Registed_Date datetime NOT Null ,
Exp_Start_Date DateTime NOT NULL,
Exp_End_Date DateTime NOT NULL,
Status  Varchar(20) NOT NULL,
ManagerId Varchar(20) NOT NULL,
Foreign Key (GCMId) references GCM(GCMId),
Foreign Key(EmpId) references Employee(EmpId),
Foreign Key (TravelId) references Travel(TravelId),
Foreign Key(CountryId) references Country(CountryId),
Foreign Key(CityId) references City(CityId),
Foreign Key(ManagerId) references Employee(EmpId));

Insert into Travelers values(1001,"WGS1144",2,103,"CUB",13,"2022-09-04","2022-10-04","2023-05-03","Approved","WGS0867");
Insert into Travelers values(1002,"WGS2255",1,101,"USA",6,"2022-09-04","2022-12-13","2024-05-03","Approved","WGS1694");
Insert into Travelers values(1003,"WGS2587",3,104,"ITA",8,"2022-09-04","2022-10-25","2023-10-03","Approved","WGS0867");
Insert into Travelers values(1004,"WGS9966",2,102,"IND",3,"2022-08-25","2022-11-04","2023-11-03","Approved","WGS1694");
Insert into Travelers values(1005,"WGS3366",3,101,"IND",1,"2022-08-25","2022-10-16","2024-05-03","Approved","WGS0867");
Insert into Travelers values(1006,"WGS2022",2,104,"FRA",12,"2022-08-25","2022-10-25","2023-09-25","Approved","WGS1694");


create table EmployeePersonalInfo(
ResponseId int not null auto_increment primary Key,
LastName varchar(20) Not null,
FirstName varchar(20) not null,
EmpId varchar(20) not null,
DateOfBirth datetime not null,
Gender varchar(20) not null,
PrimaryCitizenship varchar(20) not null,
SecondaryCitizenship varchar(20) not null,
DasId varchar(20) ,
Email varchar(30) not null,
GCM_Id_Home_Country int not null,
GCM_Id_Host_Country int not null,
foreign key (EmpId) references Employee(EmpId),
foreign key (GCM_Id_Home_Country) references GCM(GCMId),
foreign key (GCM_Id_Host_Country) references GCM(GCMId));


Create table EmployeeFamilyInfo(
FamilyId int not null auto_increment primary key,
EmpId varchar(20) not null,
Family_Status_Home_Country varchar(20) not null,
Family_Host_Country varchar(20) not null,
Spouse_location varchar(20) not null,
foreign key(EmpId) references Employee(EmpId));



Create table EmployeeChildrenInfo(
ChildId int not null auto_increment primary key,
ChildrenName varchar(20),
EmpId varchar(20) not null,
ChildDateOfBirth datetime not null,
PrimaryCitizenship varchar(20) not null,
Dependent_for_tax_purpose_in_home_country varchar(20) not null,
foreign key(EmpId) references Employee(EmpId));


create table AssignmentContactInfo(
ContactId int not null auto_increment primary key,
EmpId varchar(20) not null,
BudgetHolderName varchar(20) not null,
BudgetHolder_Email varchar(30) not null,
Home_HR_Director_Name varchar(20) not null,
Home_HR_Director_Email varchar(30) not null,
Home_Line_Manager_Name varchar(20) not null,
Home_Line_Manager_Email varchar(30) not null,
Host_HR_Director_Name varchar(20) not null,
Host_HR_Director_Email varchar(30) not null,
Host_Line_Manager_Name varchar(20),
Host_Line_Manager_Email varchar(30),
foreign key (EmpId) references Employee(EmpId));


create table ProjectDetailInfo(
ProjectId int not null auto_increment primary key,
EmpId varchar(20) not null,
Role_in_Host_Country varchar(20) not null,
Role_description_Host_Country varchar(50) not null ,
Annual_base_Salary decimal not null,
Worldline_Entity_name_bearing_costs varchar(20) not null,
worldline_costs_centre_bearing_costs varchar(20) not null,
Client_name_for_whome_Employee_Working varchar(20),
Project_name_on_which_Employee_Working varchar(20),
Nature_of_Activity varchar(20) not null,
Worldline_recruitment varchar(20),
foreign key (EmpId) references Employee(EmpId));

create table AssignmentDetailInfo(
DetailId int not null auto_increment primary key,
EmpId varchar(20) not null,
HomeCountryId varchar(20) not null,
HomeCityId int not null,
HostCountryId varchar(20) not null,
HostCityId int not null,
FromGBU varchar(20) not null,
ToGBU varchar(20) not null,
FromLegalEntity varchar(20) not null,
ToLegalEntity varchar(20) not null,
FromDivision varchar(20) not null,
ToDivision varchar(20) not null,
foreign key(EmpId) references Employee(EmpId),
foreign key(HomeCountryId) references Country(CountryId),
foreign key(HomeCityId) references City(CityId),
foreign key(HostCountryId) references Country(CountryId),
foreign key(HostCityId) references City(CityId));

create table AssignmentConditionInfo(
ConditionId int not null auto_increment primary key,
EmpId varchar(20) not null,
Expected_Start_Date datetime not null,
Expected_End_Date datetime not null,
Reason_Mobility_Request varchar(20) not null,
Employee_Replacing_International_Employee varchar(10) not null,
Employee_Reporting_To varchar(20) not null,
Performance_review_done_by varchar(20) not null,
Employee_Work_Full_Time_in_HostCountry varchar(10) not null,
Employee_Work_not_Full_Time_then_Estimated_Work_Schedule varchar(10) ,
Employee_relationship_host_country varchar(20) not null,
Why_local_employee_not_consider_for_this_position varchar(20) not null,
foreign key (EmpId) references Employee(EmpId));



select * from AssignmentDetailInfo;
select * from EmployeePersonalInfo;
select * from AssignmentConditionInfo;
select * from ProjectDetailInfo;
select * from EmployeeChildrenInfo;
select * from EmployeeFamilyInfo;
Select * from AssignmentContactInfo;
select * from Employee;
select * from UserLogin;
select * from GCM;
select * from Travel;
select * from City;
select * from Country;
select * from Travelers;
select * from Manager;

truncate table EmployeePersonalInfo;
truncate table EmployeeFamilyInfo;
truncate table AssignmentContactInfo;
truncate table projectdetailinfo;
truncate table assignmentconditioninfo;
truncate table assignmentdetailinfo;
truncate table employeechildreninfo;

drop table AssignmentContactInfo;
drop table ProjectDetailInfo;
drop table AssignmentConditionInfo;
drop table employeechildreninfo;
