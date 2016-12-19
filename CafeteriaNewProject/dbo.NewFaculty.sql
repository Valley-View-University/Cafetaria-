CREATE TABLE [dbo].[NewFaculty] (
    [Id]          INT          NOT NULL,
    [First Name]  CHAR (10)    NULL,
    [Middle Name] CHAR (10)    NULL,
    [Last Name]   CHAR (10)    NULL,
    [Department]  VARCHAR (50) NULL,
    [Gender]      VARCHAR (50) NULL,
    [Faculty ID]  VARCHAR (50) NULL,
    [Password]    VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

