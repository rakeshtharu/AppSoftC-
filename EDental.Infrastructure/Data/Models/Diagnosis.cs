using EDental.Data.Enums;
namespace EDental.Data.Models
{
    public class Diagnosis
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DiagnosisName { get; set; }
        public string Procedures { get; set; }
        public string Medication { get; set; }
    }
}
