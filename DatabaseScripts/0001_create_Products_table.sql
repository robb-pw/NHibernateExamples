create table Products (
	Id int not null,
	Name nvarchar(50) not null,
	UnitPrice money not null,
	ReorderLevel int not null,
	Discontinued bit not null,
	Description nvarchar(MAX),
	primary key (Id)
)
GO

IF EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID('CK_Products_ReorderLevel')
	AND parent_object_id = OBJECT_ID('Products'))
	ALTER TABLE Product DROP CONSTRAINT CK_Products_ReorderLevel
GO

IF EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID('Product') AND name = 'IX_Products_Name')
	DROP INDEX IX_Products_Name ON Product
GO

CREATE UNIQUE INDEX IX_Products_Name
ON Products (Name ASC)
GO