CREATE TABLE [dbo].[Owner] (
    [NationalCode] NVARCHAR (10) NOT NULL,
    [Name]         NCHAR (20)    NOT NULL,
    [Surname]      NCHAR (20)    NOT NULL,
    [Gender]       BIT           NOT NULL,
    [Description]  NCHAR (30)    NOT NULL,
    PRIMARY KEY CLUSTERED ([NationalCode] ASC)
);

