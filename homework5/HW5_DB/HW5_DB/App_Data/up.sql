-- UserRequests table
CREATE TABLE [dbo].[UserRequests]
(
	[ID]	INT IDENTITY(1,1)	NOT NULL,
	[FirstName]	NVARCHAR(64)	NOT NULL,
	[LastName]	NVARCHAR(64)	NOT NULL,
	[PhoneNumber]	NVARCHAR(64)	NOT NULL,
	[AptName]	NVARCHAR(64)	NOT NULL,
	[Unit]	NVARCHAR(64)	NOT NULL,
	[Expl]	NVARCHAR(256)	NOT NULL
	CONSTRAINT [PK_dbo.UserRequests] PRIMARY KEY CLUSTERED([ID] ASC)
);

INSERT INTO [dbo].[UserRequests](FirstName, LastName, PhoneNumber, AptName, Unit, Expl) VALUES
	('John', 'Leo', '487-324-1111', 'Sideway', 27, 'Repair roof'),
	('Alen', 'Tim', '487-324-2222', 'Sideway', 14, 'Repair oven'),
	('Kim', 'Chen', '487-324-3333', 'Sideway', 32, 'Regular cleaning')
GO