CREATE PROCEDURE spLogin
    @Usuario VARCHAR (50),
    @Contrasena VARCHAR(50)
AS  

BEGIN
    SELECT TOP 1 COUNT(*) FROM Usuarios
    WHERE Usuarios.Usuario = @Usuario AND Usuarios.Contrasena = @Contrasena
END
GO