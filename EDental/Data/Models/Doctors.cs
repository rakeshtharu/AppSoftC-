using EDental.Data.Enums;

namespace EDental.Data.Models
{
    public class Doctors
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string NDCNumber { get; set; }
        public string Qualification { get; set; }
        public string Specialization { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }

    }
}
