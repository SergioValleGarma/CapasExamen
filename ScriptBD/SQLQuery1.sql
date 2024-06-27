USE [WICMonitoriaDBDev]
GO


create proc sp_CreateRegin
@RegionName nvarchar(100),
@Enabled bit
as
Begin 
	INSERT INTO [dbo].[Regions]
           ([RegionName],[Enabled])
     VALUES
           (@RegionName,@Enabled)
end

alter proc sp_ReadRegions
@RegionName nvarchar(100)
as
begin

SELECT [RegionId]
      ,[RegionName]
      ,[Enabled]
  FROM [dbo].[Regions] where [Enabled] =1

end

create proc sp_UpdateRegion
@RegionId int,
@RegionName nvarchar(100),
@Enabled bit
as
Begin 

UPDATE [dbo].[Regions]
   SET [RegionName] = @RegionName
      ,[Enabled] = @Enabled
 WHERE RegionId = @RegionId

end

create proc sp_DeleteRegion
@RegionId int
as
begin
UPDATE [dbo].[Regions]
   SET [Enabled] = 0
 WHERE RegionId = @RegionId

end

select * from Regions
sp_CreateRegin 'prueba1',1
sp_ReadRegions 'Prueba'
sp_UpdateRegion 82,'prueba82',1
sp_DeleteRegion 82