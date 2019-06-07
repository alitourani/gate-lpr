CREATE TABLE [dbo].[ValidList] (
    [LPNumber]     NVARCHAR (11) NOT NULL,
    [OwnerID]      NVARCHAR (10) NOT NULL,
    [VehicleType]  NVARCHAR (25) NOT NULL,
    [VehicleColor] NVARCHAR (15) NOT NULL,
    [VehicleImage] NVARCHAR(50)         NULL,
    PRIMARY KEY CLUSTERED ([LPNumber] ASC)
);

