USE LibraryDB

-- Tabla Book
INSERT INTO Books 
VALUES ('El principito','Pablo Neruda', 1998),
('Romeo y Julieta','William sheaspeare',1998),
('Algebra','Baldor',2000),
('libro3','autor3',1992),
('libro4','autor4',1992),
('libro5','autor5',1992)

SELECT BookID, Title, Author, PublishedYear FROM Books
SELECT * FROM Books
SELECT Title FROM Books

SELECT * FROM Books WHERE PublishedYear = 1992

UPDATE Books SET Title = 'El arte de la guerra', Author = 'Sun Tzu' WHERE BookID = 4

-- Tabla members

INSERT INTO Members 
VALUES ('Erick Martínez','2024-09-11','erick@mail.com'),
('Isaías Pérez','2024-09-13','isaias@mail.com'),
('Gustavo Rivas','2024-09-28','gus@mail.com'),
('Orlando Zuniga','2024-09-21','zuniga@mail.com'),
('Orlin MAnzanarez','2023-09-11','orlin@mail.com')

SELECT * FROM Members

UPDATE Members SET FullName = 'Ernesto Ortiz' WHERE MemberID = 5

DELETE FROM Members WHERE MemberID = 2

-- Tabla Loans

INSERT INTO Loans
VALUES ('2024-09-11', 3, 1)

SELECT * FROM Loans


UPDATE Loans SET BookID = 3 WHERE LoanID = 1

DELETE FROM Loans WHERE LoanID = 1