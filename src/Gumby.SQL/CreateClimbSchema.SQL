DROP TABLE IF EXISTS Climb.Route
DROP TABLE IF EXISTS Climb.Journal
GO;

DROP SCHEMA Climb;
GO;

CREATE SCHEMA Climb;
GO;

CREATE TABLE Climb.Route(
    Id uniqueidentifier NOT NULL PRIMARY KEY,
    Name varchar(255)
);
CREATE TABLE Climb.Journal(
    Id uniqueidentifier NOT NULL PRIMARY KEY,
    Name varchar(255),
	OccurredAt datetimeoffset,
	RouteId uniqueidentifier FOREIGN KEY REFERENCES Climb.Route(Id),
	ProtectionType int
);
GO;