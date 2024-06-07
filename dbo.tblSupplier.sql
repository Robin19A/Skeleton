CREATE TABLE [dbo].[tblSupplier] (
    [SupplierId]   INT           IDENTITY (1, 1) NOT NULL,
    [SupplierName] VARCHAR (30) NOT NULL,
    [Address]      VARCHAR (30) NULL,
    [Phone]        VARCHAR (20)  NULL,
    [Email]        VARCHAR (40) NULL,
    [DateAdded]    DATE          NULL,
    [Active]       BIT           NULL,
    PRIMARY KEY CLUSTERED ([SupplierId] ASC)
);

