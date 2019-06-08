CREATE TABLE [dbo].[Report] (
    [LPNumber]     NVARCHAR (11) NOT NULL,
    [OwnerID]      NVARCHAR (10) NOT NULL,
    [Valid]        BIT           NOT NULL,
    [Date]         DATETIME2 (7) NOT NULL,
    [Time]         TIME (7)      NOT NULL,
    [LPImage]      NVARCHAR(50)         NULL,
    [VehicleImage] NVARCHAR(50)         NULL,
    PRIMARY KEY CLUSTERED ([LPNumber] ASC)
);

