USE [FACILITY MANAGEMENT SYSTEM];

INSERT INTO Person VALUES 
(100211526,'Matthew Stafford', 'matt.stafford@gmail.com', 'Male', '19950222', '604-231-9925', '119', 'Ramsey St.', 'Burnaby', 'BC', 'V3F 1H1', 'Guest'), 
(100987454, 'Paige Vanzant', 'VanzantP@hotmail.com', 'Female', '19990415', '565-397-6473', '323', 'Griffin St.', 'Surrey', 'BC', 'V5G 8M2', 'Guest'),
(100267341, 'Holly Molly', 'holmol@outlook.com', 'Female', '20010814', '664-781-3147', 'Unit-56', '6680 Wilson St.', 'Burnaby', 'BC', 'V5G 8M2', 'Guest'),
(900478228, 'Candace Parker', 'ParkC0882@gmail.com',  'Female', '20061231', '687-155-3569', 'Apt# 101', '6176 Parker Avenue', 'New Westminster', 'BC', 'V1F 6G3', 'Tenant'),
(900632698, 'Aaron Donald', 'ADonald@outlook.com',  'Female', '20020920', '996-141-2544', 'Apt# 102', '6174 Parker Avenue', 'New Westminster', 'BC', 'V1F 6G3', 'Tenant'),
(900414749, 'Jalen Chase', 'chasej999@yahoo.com',  'Male', '20101104', '654-898-4471', 'Apt# 201', '6175 Parker Avenue', 'New Westminster', 'BC', 'V1F 6G3', 'Tenant')
SELECT * from Person

INSERT INTO Building VALUES 
('Holland Building',  '6174', 'Parker Avenue', 'New Westminster,', 'BC', 'V1F 6G3'),
('Maguire Building', '6175', 'Parker Avenue', 'New Westminster,', 'BC', 'V1F 6G3'),
('Garfield Building', '6176', 'Parker Avenue', 'New Westminster,', 'BC','V1F 6G3')
SELECT * from Building

INSERT INTO Facility VALUES 
('The Nile', 'Swimming Pool', 'Olympic size pool with diving board'), 
('Olympus', 'Social Hall', 'Big Room for big party'),
('Iron Will', 'Gym', 'Body Building and MMA training'),
('Novak', 'Tennis Court', 'Wimbledon style clay court')
SELECT * from Facility

INSERT INTO Facility_Location VALUES
('The Nile', 'Holland Building', '14th Flr'),
('Olympus', 'Maguire Building', '15th Flr'),
('Iron Will', 'Garfield Building', '12th Flr'),
('Novak', 'Holland Building', '13th Flr')
SELECT * from Facility_Location

INSERT INTO Employee VALUES
(100349, 'Jack Daniels'),
(100541, 'Johnny Walker'),
(100774, 'Jim Beam'),
(100216, 'Glen Moray')
SELECT * from Employee

INSERT INTO Reservation VALUES
(455120, '20220311', '08:00:00 PM', '09:00:00 PM', 12, 'Showed Up', 0, 100541, 'The Nile', 900478228),
(455121, '20220315', '08:00:00 AM', '10:00:00 AM', 8, 'Pending', 0, 100349, 'The Nile', 900632698),
(455122, '20220401', '07:00:00 PM', '09:00:00 PM', 20, 'Pending', 500, 100541, 'Olympus', 100211526),
(455123, '20220322', '07:00:00 PM', '08:00:00 PM', 10, 'Pending', 2500, 100774, 'Novak', 100987454),
(455124, '20220326', '09:00:00 AM', '12:00:00 PM', 7, 'Pending', 0, 100216, 'Iron Will', 900414749),
(455125, '20220311', '06:00:00 PM', '07:00:00 PM', 15, 'Pending', 1000, 100774, 'Olympus', 100267341)
SELECT * from Reservation

INSERT INTO Tenants_Dependents VALUES
(900632698, 'Joe Burrow', '19330101', 'Male', 'Spouse'),
(900414749, 'Cooper Kupp', '19540423', 'Female', 'Child')
SELECT * from Tenants_Dependents

INSERT INTO Building_Apartment VALUES
('Holland Building', 101),
('Maguire Building', 102),
('Garfield Building', 201)
SELECT * from Building_Apartment

INSERT INTO Tenants_Resides_in_Apartment VALUES
(900478228, 'Holland Building', 101, '20220101', '20221231'),
(900632698, 'Maguire Building', 201, '20200101', '20251231')
SELECT * from Tenants_Resides_in_Apartment

INSERT INTO Building_Has_Facility VALUES
('Holland Building', 'The Nile'),
('Maguire Building', 'Olympus'),
('Garfield Building', 'Novak'),
('Holland Building', 'Iron Will')
SELECT * from Building_Has_Facility
