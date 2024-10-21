using EDental.Data.Enums;
namespace EDental.Data.Models
{
    public class Diagnosis
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string DiagnosisName { get; set; }
        public string MedicationPrescribed { get; set; }
        public DiagnosisStatus DiagnosisStatus { get; set; }
    }
}
