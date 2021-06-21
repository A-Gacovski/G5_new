--HOMEWORK 1/6

SELECT * FROM Student
WHERE FirstName = 'Antonio'

SELECT * FROM Student
WHERE DateOfBirth > '1999.01.01'

SELECT * FROM Student
WHERE Gender = 'M'

SELECT * FROM Student
WHERE LastName like 'T%'

SELECT * FROM Student
WHERE EnrolledDate >= '1998.01.01' AND EnrolledDate <= '1998.01.31'

SELECT * FROM Student
WHERE EnrolledDate >= '1998.01.01' AND EnrolledDate <= '1998.01.31'
AND LastName like 'J%'

--HOMEWORK 2/6

SELECT * FROM Student
WHERE FirstName = 'Antonio'
ORDER BY LastName

SELECT * FROM Student
ORDER BY FirstName

SELECT * FROM Student
WHERE Gender = 'M'
ORDER BY EnrolledDate DESC

--HOMEWORK 3/6

SELECT FirstName
FROM Teacher
UNION ALL
SELECT FirstName
FROM Student
GO

SELECT LastName
FROM Teacher
UNION
SELECT LastName
FROM Student
GO

SELECT FirstName
FROM Teacher
INTERSECT
SELECT FirstName
FROM Student
GO

--HOMEWORK 4/6

ALTER TABLE [dbo].[GradeDetails]
ADD CONSTRAINT DF_GradeDetails_AchievementMaxPoints
DEFAULT 100 FOR [AchievementMaxPoints]
GO

ALTER TABLE [dbo].[GradeDetails] WITH CHECK
ADD CONSTRAINT CHK_GradeDetails_AchievementPoints
CHECK (AchievementPoints <= AchievementMaxPoints)
GO

ALTER TABLE [dbo].[AchievementType] WITH CHECK
ADD CONSTRAINT UC_AchievementType_Name
UNIQUE (Name)
GO

--HOMEWORK 5/6

ALTER TABLE [dbo].[Course] WITH CHECK
ADD CONSTRAINT FK_Course_Id
FOREIGN KEY ([Id])
REFERENCES [dbo].[Teacher]([Id])
GO

--HOMEWORK 6/6

SELECT c.Name as CourcesName, a.Name as AchievementTypesName
FROM dbo.Course c
CROSS JOIN dbo.AchievementType a
GO

SELECT t.*
FROM dbo.Teacher t
INNER JOIN dbo.Grade g ON t.Id = g.Id
GO

SELECT t.*
FROM dbo.Teacher t
LEFT JOIN dbo.Grade g ON t.Id = g.Id
WHERE g.Grade IS NULL

SELECT s.*
FROM dbo.Grade g
RIGHT JOIN dbo.Student s ON g.Id = s.Id
WHERE g.Grade IS NULL

