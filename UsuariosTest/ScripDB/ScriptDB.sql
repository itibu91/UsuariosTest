CREATE TABLE Usuarios (
    ID INT Identity (1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    Correo VARCHAR(100),
    Edad INT
);

INSERT INTO Usuarios (Nombre, Correo, Edad) VALUES
    ('Juan P�rez', 'juan@example.com', 25),
    ('Mar�a G�mez', 'maria@example.com', 30),
    ('Carlos L�pez', 'carlos@example.com', 22),
    ('Ana Mart�nez', 'ana@example.com', 28),
    ('Luis Rodr�guez', 'luis@example.com', 35),
    ('Laura S�nchez', 'laura@example.com', 31),
    ('Miguel Torres', 'miguel@example.com', 29),
    ('Isabel Garc�a', 'isabel@example.com', 26),
    ('Roberto Rodr�guez', 'roberto@example.com', 35),
    ('Laura Torres', 'laura@example.com', 29),
    ('Miguel Garc�a', 'miguel@example.com', 31),
    ('Isabel P�rez', 'isabel@example.com', 27);

select * from Usuarios;


