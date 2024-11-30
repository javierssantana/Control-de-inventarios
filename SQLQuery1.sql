-- Crear la base de datos componentes
CREATE DATABASE componentes;
GO

-- Usar la base de datos componentes
USE componentes;
GO
select * from productos
-- Crear la tabla productos con las columnas especificadas
CREATE TABLE productos (
    id_comp INT IDENTITY(1,1) PRIMARY KEY,
    num_comp VARCHAR(4) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    existencias INT NOT NULL,
    imagen IMAGE
);
GO

CREATE PROCEDURE SP_BuscarProducto
    @CodProd VARCHAR(4)
AS
BEGIN
    SELECT id_comp, num_comp, nombre, existencias, imagen
    FROM productos
    WHERE num_comp = @CodProd;
END;

CREATE PROCEDURE SP_AñadirProducto
    @NumComp VARCHAR(4),
    @Nombre VARCHAR(50),
    @Existencias INT,
    @Imagen IMAGE
AS
BEGIN
    INSERT INTO productos (num_comp, nombre, existencias, imagen)
    VALUES (@NumComp, @Nombre, @Existencias, @Imagen);
END;

CREATE PROCEDURE SP_EliminarProducto
    @CodProd VARCHAR(4)
AS
BEGIN
    DELETE FROM productos
    WHERE num_comp = @CodProd;
END;

CREATE PROCEDURE SP_ModificarProducto
    @CodProd VARCHAR(4),
    @Nombre VARCHAR(50),
    @Existencias INT,
    @Imagen IMAGE
AS
BEGIN
    UPDATE productos
    SET nombre = @Nombre, existencias = @Existencias, imagen = @Imagen
    WHERE num_comp = @CodProd;
END;

CREATE PROCEDURE SP_MostrarTodosProductos
AS
BEGIN
    SELECT id_comp, num_comp, nombre, existencias, imagen
    FROM productos;
END;

select * from productos