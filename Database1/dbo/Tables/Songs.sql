CREATE TABLE [dbo].[Songs] (
    [name] NVARCHAR (50)  NULL,
    [path] NVARCHAR (MAX) NULL,
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_Songs] PRIMARY KEY CLUSTERED ([Id] ASC)
);

