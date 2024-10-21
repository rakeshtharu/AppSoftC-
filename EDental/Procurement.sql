CREATE TABLE Procurement (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Particulars NVARCHAR(MAX),
    Vendor NVARCHAR(200),
    Price FLOAT,
    Quantity INT,
    Warranty TIME,
    Date DATETIME2
    );