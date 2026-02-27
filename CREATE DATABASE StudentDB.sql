CREATE DATABASE StudentDB
GO

USE StudentDB
GO

CREATE TABLE Users(
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50),
    Password NVARCHAR(100),
    Role NVARCHAR(20)
)

CREATE TABLE Students(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Age INT,
    Major NVARCHAR(100)
)
