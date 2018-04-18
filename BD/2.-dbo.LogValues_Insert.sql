IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'LogValues_Insert')
   exec('CREATE PROCEDURE [dbo].[LogValues_Insert] AS BEGIN SET NOCOUNT ON; END')
GO

/**********************************************************************          
$Archive  : [LogValues_Insert]          
$Revision :           
$Author   : Luis Begazo 
$Modtime  : 
$History  :           
**********************************************************************/      

ALTER PROCEDURE [dbo].[LogValues_Insert]        
( 
	@message VARCHAR(MAX)
)
AS

BEGIN

		INSERT INTO TLogMessage(Message)
		VALUES(@message)

		
		DECLARE @IdLogValues BIGINT      
		Set @IdLogValues =SCOPE_IDENTITY()     

		SELECT @IdLogValues
END;

