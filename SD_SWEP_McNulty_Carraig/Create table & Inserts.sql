Drop table  Payments;
Drop table  Repair_Parts;
Drop table  Repairs;
Drop table  parts;
Drop table  part_types;

--------------------------------------------------------
--  Create Part_Types
--------------------------------------------------------
CREATE TABLE Part_Types
(
Part_Type varchar(20),
Description varchar (100),
CONSTRAINT pk_PType PRIMARY KEY (Part_Type));

--------------------------------------------------------
-- Part Types insert
--------------------------------------------------------

Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('MOBO | ATX','Full Sized Motherboard used in ATX cases only');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('MOBO | Micro-ATX','Middle Sized Motherboard used in Mico ATX/ATX cases that support them');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('MOBO | Mini-ATX','Smallest Sized Motherboard used in any sized cases that can support them');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('HDD | 3.5" ','Bigger 3.5 inch Hard Drives Insert into Hard drive cage');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('HDD | 2.5" ','Smaller 2.5 inch Hard Drives Insert into Hard drive cage');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('SSD | SATA','2.5 inch Solid State Drives Insert into Hard drive cage');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('SSD | M.2','Non-Volatile Memory Express M.2 Drive ensure motherboad capablity');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('SSD | PCIe','Non-Volatile Memory Express PCIe Drive ensure motherboad capablity');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('PSU | Semi','Semi Modular Power supply');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('PSU | Full','Fuly Modular Power supply');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('CPU | Intel','Intel Processor');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('CPU | AMD','AMD Processor');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('RAM | DDR2','RAM size determined by Model No');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('RAM | DDR3','RAM size determined by Model No');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('RAM | DDR4','RAM size determined by Model No');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('NIC','Standard Network Interface Card ');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('OS | Windows','Operating system for windows');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('HDD | 2.5','Smaller 2.5 inch hard drive. Inserts into a hard drive cage');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('HDD | 3.5','Larger 3.5 inch hard drive. Inserts into a hard drive cage');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('Case | Full','Full Sized Case supports any motherboard');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('Case | Mid','Middle Sized Case supports Mico ATX/Mini ATX motherboard');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('Case | Micro','Smallest Case supports Mini ATX motherboard only');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('USB | 2.0','USB 2.0');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('USB | 3.0','USB 3.0 faster than USB 2.0 Use only in cases and motherboards that have support');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('Keyboard','Keyboard');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('Mouse','Mouse');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('OpticalDrive','Optical Disk Drive use only in cases that support');
Insert into PART_TYPES (PART_TYPE,DESCRIPTION) values ('CPU Cooler','Cooler for cpu');




--------------------------------------------------------
--  Create Parts
--------------------------------------------------------
CREATE TABLE Parts
(
Part_ID numeric(5),
Parts_Model varchar(35) NOT NULL,
Part_Type varchar(20),
Unit_Price numeric(6,2),
CONSTRAINT pk_Partid PRIMARY KEY (Part_ID),
CONSTRAINT fk_partType FOREIGN KEY (Part_Type) references Part_Types);

--------------------------------------------------------
--  Parts insert
--------------------------------------------------------

Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (2,'MSI B450 TOMAHAWK','PSU | Semi',114.89);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (1,'MSI Z370-A PRO','MOBO | ATX',108);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (3,'ASUS PRIME Z390-A','MOBO | ATX',188.99);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (4,'MSI B450 GAMING PLUS','MOBO | ATX',102.03);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (11,'G.SKILL TRIDENT Z RGB','RAM | DDR4',104.99);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (12,'CORSAIR VENGEANCE RGB PRO','RAM | DDR4',115.98);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (13,'G.SKILL RIPJAWS V SERIES','RAM | DDR4',100.98);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (8,'WESTERN DIGITAL WDS500G2B0B','SSD | M.2',67.89);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (9,'I79900K','CPU | Intel',189.99);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (10,'ASUS PRIME X470-PRO','MOBO | ATX',139.99);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (14,'G.SKILL RIPJAWS V SERIES','RAM | DDR4',66.99);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (15,'	SEAGATE ST3000DM008','SSD | SATA',79.89);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (16,'SEAGATE ST3000DM008','SSD | SATA',99.99);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (17,'SEAGATE ST3000DM008','Case | Full',69.99);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (18,'	SEAGATE ST3000DM008','Case | Full',99.98);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (19,'NZXT H700I','Case | Full',179.99);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (20,'ROSEWILL FBM-X1','Case | Micro',26.99);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (21,'NZXT H200 (WHITE)','Case | Micro',78.99);
Insert into PARTS (PART_ID,PARTS_MODEL,PART_TYPE,UNIT_PRICE) values (22,'WINDOWS 10','OS | Windows',99.99);


--------------------------------------------------------
--  Repairs
-------------------------------------------------------- 
 CREATE TABLE Repairs
( 
Repair_ID numeric(5),
Repair_Cost numeric(6,2),
Status  varchar(20) CHECK (Status IN( 'Pending', 'Estimated','Processing','Completed')),
Forename varchar (25),
Surname varchar (25),
Phone_No char (10), 
Email varchar(80),
Repair_Description varchar(150),
Log_Date Date,
Completion_Date date,
CONSTRAINT pk_ModelNo PRIMARY KEY (Repair_ID));

--------------------------------------------------------
--  Repairs insert
--------------------------------------------------------

Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (3,0,'Pending','Dara','Smith','0871234567','d@gmail.com',' new cpu needed',to_date('12-APR-19','DD-MON-RR'),null);
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (4,0,'Pending','niall','nialson','0871234546','nil56332@gmail.com','solder gone on motherboard ',to_date('12-APR-19','DD-MON-RR'),null);
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (5,0,'Pending','Emma ','Nolan','0871234567','emmamn@gmail.com','New hdd required current on bricked',to_date('12-APR-19','DD-MON-RR'),null);
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (6,99.99,'Estimated','John','B.Keane','0871234567','jb.kean12345@gmail.com','New os needed windows 10 reccommended',to_date('12-APR-19','DD-MON-RR'),null);
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (1,229.78,'Processing','Carraig ','Mc Nulty','0871234567','carraigmcnlty@gmail.com','Motherboard Broken , new ssd needed',to_date('12-APR-19','DD-MON-RR'),null);
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (2,78.99,'Estimated','Sarah','O''Connor','0871234656','sara@gmail.com','New  case needed.',to_date('12-APR-19','DD-MON-RR'),null);
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (7,377.98,'Completed','Brenda','Heffernan','0871236547','brendheffernam1597@gmail.com','New Mobo Required',to_date('12-APR-19','DD-MON-RR'),to_date('12-FEB-19','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (8,135.78,'Completed','James','Macarty','0871234567','jamesmc12345657@gmail.com','New Hard Drive Required',to_date('12-APR-19','DD-MON-RR'),to_date('12-APR-19','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (9,347.97,'Estimated','Colm ','Gallagher','0871234567','colm.gallagher@students.ittralee.ie','Need a new case colm added a cpu',to_date('12-APR-19','DD-MON-RR'),null);
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (10,547.86,'Completed','Caitie ','Pearce','0871234567','caitie80@hotmail.co.uk','New os required',to_date('12-JAN-19','DD-MON-RR'),to_date('12-MAR-19','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (11,377.98,'Completed','Brenda','Heffernan','0871236547','brendheffernam1597@gmail.com','New Mobo Required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-FEB-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (12,135.78,'Completed','James','Macarty','0871234567','jamesmc12345657@gmail.com','New Hard Drive Required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-APR-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (13,547.86,'Completed','Caitie ','Pearce','0871234567','caitie80@hotmail.co.uk','New os required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-MAR-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (14,377.98,'Completed','Brenda','Heffernan','0871236547','brendheffernam1597@gmail.com','New Mobo Required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-FEB-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (15,135.78,'Completed','James','Macarty','0871234567','jamesmc12345657@gmail.com','New Hard Drive Required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-APR-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (16,547.86,'Completed','Caitie ','Pearce','0871234567','caitie80@hotmail.co.uk','New os required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-MAR-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (17,377.98,'Completed','Brenda','Heffernan','0871236547','brendheffernam1597@gmail.com','New Mobo Required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-FEB-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (18,135.78,'Completed','James','Macarty','0871234567','jamesmc12345657@gmail.com','New Hard Drive Required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-APR-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (19,547.86,'Completed','Caitie ','Pearce','0871234567','caitie80@hotmail.co.uk','New os required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-MAR-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (20,377.98,'Completed','Brenda','Heffernan','0871236547','brendheffernam1597@gmail.com','New Mobo Required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-FEB-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (21,135.78,'Completed','James','Macarty','0871234567','jamesmc12345657@gmail.com','New Hard Drive Required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-APR-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (22,547.86,'Completed','Caitie ','Pearce','0871234567','caitie80@hotmail.co.uk','New os required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-MAR-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (23,377.98,'Completed','Brenda','Heffernan','0871236547','brendheffernam1597@gmail.com','New Mobo Required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-FEB-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (24,135.78,'Completed','James','Macarty','0871234567','jamesmc12345657@gmail.com','New Hard Drive Required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-APR-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (25,547.86,'Completed','Caitie ','Pearce','0871234567','caitie80@hotmail.co.uk','New os required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-MAR-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (26,377.98,'Completed','Brenda','Heffernan','0871236547','brendheffernam1597@gmail.com','New Mobo Required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-FEB-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (27,135.78,'Completed','James','Macarty','0871234567','jamesmc12345657@gmail.com','New Hard Drive Required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-APR-18','DD-MON-RR'));
Insert into REPAIRS (REPAIR_ID,REPAIR_COST,STATUS,FORENAME,SURNAME,PHONE_NO,EMAIL,REPAIR_DESCRIPTION,LOG_DATE,COMPLETION_DATE) values (28,547.86,'Completed','Caitie ','Pearce','0871234567','caitie80@hotmail.co.uk','New os required',to_date('12-JAN-18','DD-MON-RR'),to_date('12-MAR-18','DD-MON-RR'));

 
 --------------------------------------------------------
--  Repair~_Parts
--------------------------------------------------------                                 
 CREATE TABLE Repair_Parts
( 
Part_ID numeric(5),      
Repair_ID numeric(5),     
Quantity numeric(1),
CONSTRAINT pk_ids PRIMARY KEY (Repair_ID,Part_ID),
CONSTRAINT fk_Partid FOREIGN KEY (Part_ID) REFERENCES Parts ,
CONSTRAINT fk_RepId FOREIGN KEY (Repair_ID) references Repairs);

--------------------------------------------------------
--  Repair Parts insert
--------------------------------------------------------

Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (10,16,1);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (25,22,1);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (8,8,2);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (10,9,2);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (7,3,2);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (2,21,1);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (6,22,1);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (10,8,1);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (1,2,2);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (9,21,2);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (9,9,1);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (26,8,1);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (26,2,2);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (27,21,2);
Insert into REPAIR_PARTS (REPAIR_ID,PART_ID,QUANTITY) values (28,9,1);
 
--------------------------------------------------------
--  Create Payments
--------------------------------------------------------  
CREATE TABLE Payments
( 
Payment_ID numeric(5),
Repair_ID numeric(5),
Amount_Paid numeric(6,2),
Pay_Date Date,
CONSTRAINT pk_Payments PRIMARY KEY (Payment_ID),
CONSTRAINT fk_PayRepID FOREIGN KEY (Repair_ID) references Repairs);

--------------------------------------------------------
--  Payments insert
--------------------------------------------------------

Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (3,9,157.98,to_date('12-AUG-19','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (4,8,135.78,to_date('12-JUL-19','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (5,7,377.98,to_date('12-APR-19','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (6,9,157.98,to_date('12-APR-19','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (7,8,135.78,to_date('12-FEB-19','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (1,1,229.78,to_date('12-APR-19','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (2,10,547.86,to_date('12-APR-19','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (8,21,377.98,to_date('12-APR-18','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (9,22,229.78,to_date('12-APR-18','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (10,23,547.86,to_date('12-APR-18','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (11,24,157.98,to_date('12-DEC-18','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (12,25,135.78,to_date('12-APR-18','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (13,26,377.98,to_date('12-DEC-18','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (14,27,229.78,to_date('12-APR-18','DD-MON-RR'));
Insert into PAYMENTS (PAYMENT_ID,REPAIR_ID,AMOUNT_PAID,PAY_DATE) values (15,28,547.86,to_date('12-JAN-18','DD-MON-RR'));

commit;