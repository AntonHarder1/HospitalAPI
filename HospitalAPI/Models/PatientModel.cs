namespace HospitalAPI.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientGender { get; set; }
        public int PatientAge { get; set; }
        public string? PatientRequirements { get; set; }
        public string? PatientAllergies { get; set; }
        public string? PatientNotes { get; set; }

        public Patient(int patientId, string patientName, string patientGender, int patientAge, string patientRequirements, string patientAllergies, string patientNotes)
        {
            PatientId = patientId;
            PatientName = patientName;
            PatientGender = patientGender;
            PatientAge = patientAge;
            PatientRequirements = patientRequirements;
            PatientAllergies = patientAllergies;
            PatientNotes = patientNotes;
        }

        public Patient()
        {

        }
    }
}
