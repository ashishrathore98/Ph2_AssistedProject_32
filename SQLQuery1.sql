CREATE DATABASE School7;
USE School7; 

CREATE TABLE Student
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Address VARCHAR(100) NOT NULL,
    Email VARCHAR(75) NOT NULL,
    Class VARCHAR(5) NOT NULL
);

INSERT INTO Student (Name, Address, Email, Class)
VALUES ('Amit Kumar', 'E42 Delhi', 'Amit.kumar@email.com', 'A');

INSERT INTO Student (Name, Address, Email, Class)
VALUES ('Sharukh Khan', ' B24 Mannat', 'sharukh.khan@email.com', 'B');

Select * from Student




