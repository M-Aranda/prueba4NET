CREATE DATABASE registroDeEnfermedades
GO

USE registroDeEnfermedades;
GO


CREATE TABLE Enfermedad(
id INT IDENTITY(1,1),
nombre VARCHAR (50),
descripcion VARCHAR(1000),
anioDeDescubrimiento INT,
PRIMARY KEY (id)
);
GO

INSERT INTO Enfermedad VALUES('Miopia','Afecta a la vista', 1856);
INSERT INTO Enfermedad VALUES('Bulimia','Es un desorden alimenticio', 1830);
INSERT INTO Enfermedad VALUES('Obesidad','Exceso de tejdio adiposo en el cuerpo', 1870);
INSERT INTO Enfermedad VALUES('Sida','Afecta al sistema inmune', 1956);
GO


/*
SELECT * FROM Enfermedad
GO

*/

/*
USE MASTER
GO
DROP DATABASE registroDeEnfermedades
GO
*/