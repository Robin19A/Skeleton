CREATE TABLE [dbo].[tblStaff] (
    [StaffId]       INT          IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (50) NULL,
    [Email]         VARCHAR (50) NULL,
    [DateOfBirth]   DATE         NULL,
    [Gender]        VARCHAR (50) NULL,
    [Address]       VARCHAR (50) NULL,
    [Active]        BIT          NULL,
    PRIMARY KEY CLUSTERED ([StaffId] ASC)
);

