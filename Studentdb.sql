CREATE DATABASE studentdb;

CREATE TABLE [dbo].[Student] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [student_id] CHAR (8)      NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    [Year]       TINYINT       NOT NULL,
    [Department] NVARCHAR (10) NOT NULL,
    [email]      NVARCHAR (30) NOT NULL,
    [phone]      CHAR (8)      NOT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([id] ASC)
);

INSERT INTO [dbo].[Student] (
    [student_id],
    [Name],
    [Year],
    [Department],
    [email],
    [phone]
) VALUES (
    '02200174',
    'Divyash Chhetri',
    3,
    'BE IT',
    '02200174.cst@rub.edu.bt',
    '17358766'
);