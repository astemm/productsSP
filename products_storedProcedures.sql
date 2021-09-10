
CREATE PROCEDURE sp_GetAllProducts
AS

BEGIN

    SELECT * FROM [dbo].[Product1]
END

GO

CREATE PROCEDURE sp_GetProductsByIdList
      @IdList varchar(200)
AS

BEGIN
	DECLARE @SQL varchar(500)

	SET @SQL='SELECT * FROM [dbo].[Product1] WHERE ProductId IN ('+@IdList+')'

	EXEC(@SQL)
END

GO

CREATE PROCEDURE sp_GetProductById

      @Id int
AS

BEGIN

    SELECT * FROM [dbo].[Product1]

	WHERE ProductId=@Id

END