--CREATE DATABASE [FACILITY MANAGEMENT SYSTEM];

USE [FACILITY MANAGEMENT SYSTEM];

CREATE TABLE Person (
	SSN INT,
	Full_Name VARCHAR(25),
	Email VARCHAR(25),
	Gender VARCHAR(6),
	DoB DATE,
	Phone_Num VARCHAR(25),
	House_Num VARCHAR(10),
	Street VARCHAR(25),
	City VARCHAR(25),
	Province VARCHAR(25),
	ZipCode VARCHAR(10),
	Person_Type VARCHAR(25),

	PRIMARY KEY (SSN)
);

CREATE TABLE Building (
	Bldg_Name VARCHAR(25),
	Bldg_Num VARCHAR(10),
	Street VARCHAR(25),
	City VARCHAR(25),
	Province VARCHAR(25),
	ZipCode VARCHAR(10),	

	PRIMARY KEY (Bldg_Name)
);

CREATE TABLE Facility (
	Facility_Name VARCHAR(25),
	Facility_Type VARCHAR(25),
	Facility_Description VARCHAR(100),

	PRIMARY KEY (Facility_Name)
);

CREATE TABLE Facility_Location (
	Facility_Name VARCHAR(25),
	Bldg_Name VARCHAR(25),
	Flr_Num VARCHAR(10),

	PRIMARY KEY (Facility_Name),
	FOREIGN KEY (Facility_Name) REFERENCES Facility(Facility_Name) ON DELETE CASCADE,
	FOREIGN KEY (Bldg_Name) REFERENCES Building(Bldg_Name) ON DELETE CASCADE
);

CREATE TABLE Employee (
	Emp_Id INT,
	Emp_Name VARCHAR(25),

	PRIMARY KEY (Emp_Id)
);

CREATE TABLE Reservation (
	Res_Num INT,
	Res_Date DATE,
	Start_Time TIME(0),
	End_Time TIME(0),
	Num_Person INT,
	Res_Status VARCHAR(25),
	Deposit MONEY, 
	Emp_Id INT,
	Facility_Name VARCHAR(25),
	SSN INT,


	PRIMARY KEY (Res_Num),
	FOREIGN KEY (SSN) REFERENCES Person(SSN) ON DELETE CASCADE,
	FOREIGN KEY (Emp_Id) REFERENCES Employee(Emp_Id) ON DELETE CASCADE,
	FOREIGN KEY (Facility_Name) REFERENCES Facility(Facility_Name) ON DELETE CASCADE
);

CREATE TABLE Tenants_Dependents (
	SSN INT,
	Dependent_Name VARCHAR(25),	
	DoB DATE,
	Gender VARCHAR(6),
	Relationship VARCHAR(25),	

	PRIMARY KEY (Dependent_Name, SSN),
	FOREIGN KEY (SSN) REFERENCES Person(SSN) ON DELETE CASCADE
);

CREATE TABLE Building_Apartment (
	Bldg_Name VARCHAR(25),	
	Apt_Num INT,

	PRIMARY KEY (Bldg_Name, Apt_Num),
	FOREIGN KEY (Bldg_Name) REFERENCES Building(Bldg_Name) ON DELETE CASCADE
);

CREATE TABLE Tenants_Resides_in_Apartment (
	SSN INT,
	Bldg_Name VARCHAR(25),
	Apt_Num VARCHAR(3),
	Occupancy_SDate DATE,
	Occupancy_EDate DATE,
	
	PRIMARY KEY (SSN, Bldg_Name, Apt_Num),
	FOREIGN KEY (SSN) REFERENCES Person(SSN) ON DELETE CASCADE,
	FOREIGN KEY (Bldg_Name) REFERENCES Building(Bldg_Name) ON DELETE CASCADE
);

CREATE TABLE Building_Has_Facility (
	Bldg_Name VARCHAR(25),
	Facility_Name VARCHAR(25),

	PRIMARY KEY (Bldg_Name, Facility_Name),
	FOREIGN KEY (Bldg_Name) REFERENCES Building(Bldg_Name) ON DELETE CASCADE,
	FOREIGN KEY (Facility_Name) REFERENCES Facility(Facility_Name) ON DELETE CASCADE
);





