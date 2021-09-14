IF db_id('Products') IS NULL
CREATE DATABASE Products

GO

USE Products

CREATE TABLE Product1 (
	ProductId int IDENTITY(1,1) NOT NULL,
	Name varchar(50) NULL,
	DescriptionOf varchar(100) NULL,
	Photo varbinary(max) NULL,
	Price decimal(6,2) NULL,
	Category varchar(20) NULL,
	Characteristics varchar(200),
 CONSTRAINT PK_Products PRIMARY KEY CLUSTERED 
(
	ProductId ASC
)
)

GO

USE Products

INSERT INTO dbo.Product1 (Name,DescriptionOf,Photo,Price,Category,Characteristics)
SELECT 'Samsung Galaxy J5','Samsung 2-sim phone, 8GB, LTE, 13 MP-Camera'
,(SELECT *
FROM OPENROWSET(BULK N'C:\ProductsSP\images\samsung-galaxy-j5.jpg', SINGLE_BLOB) Photo),
160.00, 'Smartphones', 'Width:65mm, Height:130mm, Colour:Grey';    

INSERT INTO dbo.Product1 (Name,DescriptionOf,Photo,Price,Category,Characteristics)
SELECT 'LENOVO IdeaPad 5','Intel Ice Lake, 2 Cores, DDR4-8Gb, SSD-512GB, 15,6"'
,(SELECT *
FROM OPENROWSET(BULK N'C:\ProductsSP\images\LENOVOIdeaPad5.jpg', SINGLE_BLOB) Photo),
700.00, 'Notebooks', 'Width:356mm, Height:233mm, Colour:Grey';

INSERT INTO dbo.Product1 (Name,DescriptionOf, Photo,Price,Category,Characteristics)
SELECT 'Dell OptiPlex 3080 MMF','Intel Core i3-10100T, 3Ghz, DDR4-8Gb, SSD-256GB, Graphics 630'
,(SELECT *
FROM OPENROWSET(BULK N'C:\ProductsSP\images\OptiPlex3080MFF.jpg', SINGLE_BLOB) Photo),
750.00, 'Computers', 'Form-Factor:Micro-Tower, Colour:Black';

INSERT INTO dbo.Product1 (Name,DescriptionOf,Photo,Price,Category,Characteristics)
SELECT 'Nokia C30','Nokia 2-sim phone, 32GB, LTE, 13 MP-Camera'
,(SELECT *
FROM OPENROWSET(BULK N'C:\ProductsSP\images\nokia-c30.jpg', SINGLE_BLOB) Photo),
100.00, 'Smartphones', 'Width:79mm, Height:177mm, Colour:Grey';

INSERT INTO dbo.Product1 (Name,DescriptionOf,Photo,Price,Category,Characteristics)
SELECT 'Ball','Gaming, training, for Football'
,(SELECT *
FROM OPENROWSET(BULK N'C:\ProductsSP\images\NewBalanceP5.jpg', SINGLE_BLOB) Photo),
20.00, 'Sport', 'Manufactured in: USA, Colour:Red-White';