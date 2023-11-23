CREATE TABLE Usuarios (
    ID INT Identity (1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    Correo VARCHAR(100),
    Edad INT
);

INSERT INTO Usuarios (Nombre, Correo, Edad) VALUES
    ('Juan Pérez', 'juan@example.com', 25),
    ('María Gómez', 'maria@example.com', 30),
    ('Carlos López', 'carlos@example.com', 22),
    ('Ana Martínez', 'ana@example.com', 28),
    ('Luis Rodríguez', 'luis@example.com', 35),
    ('Laura Sánchez', 'laura@example.com', 31),
    ('Miguel Torres', 'miguel@example.com', 29),
    ('Isabel García', 'isabel@example.com', 26),
    ('Roberto Rodríguez', 'roberto@example.com', 35),
    ('Laura Torres', 'laura@example.com', 29),
    ('Miguel García', 'miguel@example.com', 31),
    ('Isabel Pérez', 'isabel@example.com', 27);

select * from Usuarios;


