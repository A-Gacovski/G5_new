-- HOMEWORK-3

--REQUIREMENT-1/3

SELECT COUNT(Grade) AS Total
FROM dbo.GRADE
GO

SELECT t.FirstName, t.LastName, COUNT(Grade) AS Total
FROM dbo.Grade g
INNER JOIN dbo.Teacher t ON t.Id = g.Id
GROUP BY t.FirstName, t.LastName
GO

SELECT t.FirstName, t.LastName, COUNT(Grade) AS Total
FROM dbo.Grade g
INNER JOIN dbo.Teacher t ON t.Id = g.Id
WHERE g.Id < 100
GROUP BY t.FirstName, t.LastName
GO

SELECT s.FirstName, s.LastName, 
MAX(Grade) AS MaxGrade, AVG(Grade) AS AverageGrade
FROM dbo.Grade g
INNER JOIN dbo.Student s ON s.Id = g.Id
GROUP BY s.FirstName, s.LastName
GO

--REQUIREMENT-2/3

SELECT t.FirstName, t.LastName, COUNT(Grade) AS Total
FROM dbo.Grade g
INNER JOIN dbo.Teacher t ON g.Id = t.Id
GROUP BY t.FirstName, t.LastName
HAVING COUNT(Grade) > 200
GO

SELECT t.FirstName, t.LastName, COUNT(Grade) AS Total
FROM dbo.Grade g
INNER JOIN dbo.Teacher t ON g.Id = t.Id
WHERE g.Id < 100
GROUP BY t.FirstName, t.LastName
HAVING COUNT(Grade) > 50
GO

SELECT s.FirstName, s.LastName, COUNT(Grade) AS Total,
MAX(Grade) AS MaxGrade, AVG(Grade) AS AverageGrade
FROM dbo.Grade g
INNER JOIN dbo.Student s ON g.Id = s.Id
GROUP BY s.FirstName, s.LastName
HAVING MAX(Grade) = AVG(Grade)
GO

SELECT s.FirstName + ' ' + s.LastName AS [Student's Name], COUNT(Grade) AS Total,
MAX(Grade) AS MaxGrade, AVG(Grade) AS AverageGrade
FROM dbo.Grade g
INNER JOIN dbo.Student s ON g.Id = s.Id
GROUP BY s.FirstName + ' ' + s.LastName
HAVING MAX(Grade) = AVG(Grade)
GO

--REQUIREMENT-3/3

--3/3-1

DROP VIEW IF EXISTS VV_StudentsGrades;
GO

CREATE VIEW VV_StudentsGrades
AS
SELECT StudentId, COUNT(Grade) As Total
FROM dbo.Grade 
GROUP BY StudentId
GO

SELECT * FROM VV_StudentsGrades
GO

--3/3-2

ALTER VIEW VV_StudentsGrades
AS
SELECT s.FirstName, s.LastName, COUNT(Grade) AS Total
FROM dbo.Student s
INNER JOIN dbo.Grade g ON s.Id = g.Id
GROUP BY s.FirstName, s.LastName
GO

--3/3-3
SELECT * FROM VV_StudentsGrades
ORDER BY TOTAL
GO
--3/3-4

DROP VIEW IF EXISTS VV_StudentGradeDetails;
GO

CREATE VIEW VV_StudentGradeDetails
AS
SELECT s.FirstName + ' ' + s.LastName AS [Student's Name],
COUNT(c.[Name]) AS Total
FROM dbo.GradeDetails gd
INNER JOIN dbo.Student s  ON gd.Id = s.Id
INNER JOIN dbo.Grade g  ON gd.Id = g.Id
INNER JOIN dbo.Course c  ON gd.Id = c.Id
GROUP BY s.FirstName + ' ' + s.LastName
GO

SELECT * FROM VV_StudentGradeDetails
GO