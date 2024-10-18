using EDental.Data.Enums;
namespace EDental.Data.Models
{
    public class Diagnosis
    {
        public int DiagnosisId { get; set; }
        public int PatientId { get; set; }
        public string DiagnosisName { get; set; }
        public DateTime DiagnosisDate { get; set; }
        public int DoctorId { get; set; }
        public string Symptoms { get; set; }
        public string MedicationPrescribed { get; set; }
        public DiagnosisStatus DiagnosisStatus { get; set; }
    }
}
