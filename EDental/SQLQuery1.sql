﻿CREATE TABLE Doctors (
Id	INT PRIMARY KEY IDENTITY(1,1), --FOR AUTO INCREMENT STARTING FORM 1 AND INCREMENTING BY 1 DIGIT
FullName NVARCHAR(100) NOT NULL,
Address NVARCHAR(255),
Phone  NVARCHAR(15),
NDCNumber NVARCHAR(50),
Qualification NVARCHAR(100),
Specialization NVARCHAR(100),
Gender INT NOT NULL,
DOB DATETIME2 NOT NULL
);