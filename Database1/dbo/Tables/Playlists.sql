CREATE TABLE [dbo].[Playlists] (
    [name] NVARCHAR (50) NULL,
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_Playlists] PRIMARY KEY CLUSTERED ([Id] ASC)
);

