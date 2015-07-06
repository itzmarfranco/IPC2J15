CREATE TRIGGER agregar_bodega
   ON ESTADO 
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for trigger here
    DECLARE @paquete AS INT
    DECLARE @estado AS VARCHAR(45)    
    SELECT @paquete = paquete, @estado = nombre
    FROM INSERTED
    IF @estado = 'En bodega'
    BEGIN
		INSERT INTO BODEGA VALUES ((SELECT lote FROM ASIGNACION_LOTE WHERE paquete = @paquete), (SELECT categoria FROM PAQUETE WHERE id = @paquete), (SELECT casilla FROM PAQUETE WHERE id = @paquete), (SELECT peso FROM PAQUETE WHERE id = @paquete), (SELECT precio FROM PAQUETE WHERE id = @paquete), 'disponible')
	END
END
GO
