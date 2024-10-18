CREATE TABLE Diagnosis (
	DiagnosisId INT PRIMARY KEY IDENTITY(1,1),
	PatientId INT NOT NULL,
	DiagnosisName NVARCHAR(100),
	DiagnosisDate DATETIME2 NOT NULL,
	DoctorId INT NOT NULL,
	Symptoms NVARCHAR(100),
	MedicationPrescribed NVARCHAR(100),
	DiagnosisStatus INT NOT NULL,
	CONSTRAINT FK_Doctor_Diagnosis FOREIGN KEY (DoctorId) REFERENCES Doctors(Id) -- Foreign key constraint
);