CREATE TABLE Admintb
(
AdminID varchar(30) NOT NULL Primary Key,
AdminName varchar(50) NOT NULL,
AdminAddress varchar(255) NOT NULL,
AdminPhone varchar(30) NOT NULL,
AdminPassword varchar(20) NOT NULL,
AdminEmail varchar(50) Not NULL
);

SELECT * FROM Admintb;

CREATE TABLE Activitytb
(
ActivityID varchar(30) NOT NULL Primary Key,
ActivityName varchar(100) NOT NULL,
MetricOne varchar(100) NOT NULL,
MetricTwo varchar(100) NOT NULL,
MetricThree varchar(100) NOT NULL
);

SELECT * FROM Activitytb;

CREATE TABLE Usertb
(
UserID varchar(30) NOT NULL Primary Key,
UserName varchar(50) NOT NULL,
UserPassword varchar(50) NOT NULL,
UserPhone varchar(50) NOT NULL,
UserEmail varchar(100) NOT NULL,
Gender varchar(30) NOT NULL,
DOB date Not Null
);

SELECT * FROM Usertb;

CREATE TABLE Tracktb
(
TrackID varchar(30) NOT NULL Primary Key,
ActivityName varchar(50) NOT NULL,
TotalCalBurn int,
TrackStatus varchar(30),
UserID varchar(30) NOT NULL,
ActivityID varchar(30) NOT NULL,
TrackDate varchar(30) NOT NULL,
Goal int NOT NULL,
Foreign Key (UserID) REFERENCES Usertb (UserID),
Foreign Key (ActivityID) REFERENCES Activitytb (ActivityID),
);

SELECT * FROM Tracktb;