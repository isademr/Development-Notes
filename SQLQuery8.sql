USE [TestDb]

select * from [dbo].[Students];


insert into [dbo].[Students] (FirstName, LastName)
VALUES ('isa','demir');

select * from [dbo].[Students]
Where Email is not null and Email != '';

-- birkaç tane daha veri ekle
-- email null olmayan kullanıcıları getir
-- departman null olmayanları getir
-- email i null olmayanları yeni bir tablo oluşturarak oraya ekle

-- iki tablo olan kullanıcıları getir

CREATE TABLE Persons (
PersonID int,
LastName varChar(255),
Firstname varChar(255),
Adress varChar(255),
City varChar(255)
);
ALTER TABLE Persons
ADD Email varchar(255);

INSERT INTO dbo.Persons(LastName,Firstname,Email)
SELECT LastName,FirstName,Email
FROM dbo.Students
Where Email is not null and Email != '';
 
select * from [dbo].[Persons];


--- student tablosunda olan ama person tablosunda olmayan verileri çek

---left join, join join 

SELECT Students.Email as EmailsInStudents, Persons.Email as EmailsInPersons, CONCAT( Students.FirstName, Students.LastName) as FullName, Students.DateOfBirth as DateOfBirth, Persons.City
FROM Students
LEFT JOIN Persons ON Students.Email = Persons.Email
Where Students.Email is not null and Students.Email != ''
ORDER BY Students.Email;



SELECT Students.Email as EmailsInStudents, Persons.Email as EmailsInPersons, Persons.LastName as LastNameFromPerson, Persons.Firstname,Persons.Adress,  CONCAT( Students.FirstName, Students.LastName) as FullName, Students.DateOfBirth as DateOfBirth, Persons.City
FROM Students
right JOIN Persons ON Students.Email = Persons.Email

Where Students.Email is not null and Students.Email != ''
ORDER BY Students.Email;


SELECT Students.Email as EmailsInStudents, Persons.Email as EmailsInPersons, Persons.LastName as LastNameFromPerson, Persons.Firstname,Persons.Adress,  CONCAT( Students.FirstName, Students.LastName) as FullName, Students.DateOfBirth as DateOfBirth, Persons.City
FROM Students
 JOIN Persons ON Students.Email = Persons.Email

