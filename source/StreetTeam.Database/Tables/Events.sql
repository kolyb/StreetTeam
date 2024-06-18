CREATE TABLE [dbo].[Events]
(
	[IdEvent] int primary key identity,
	[NameEvent] nvarchar (75) NULL,
	[DateTimeEvent] datetime NULL,
	[PlaceGameId] int NOT NULL,
	[StreetPlayerId] int NOT NULL
)
