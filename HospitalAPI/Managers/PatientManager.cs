using HospitalAPI.Models;

namespace HospitalAPI.Managers
{
    public class PatientManager
    {
        private static int _nextId = 1;

        private static readonly List<Patient> Patients = new List<Patient>
        {
            new Patient(patientId: _nextId++, patientName: "Melody", patientGender: "F", patientAge: 14, patientRequirements: "" , patientAllergies: "Latex", patientNotes: "Homesick" ),
            new Patient(patientId: _nextId++, patientName: "Jeremy", patientGender: "M", patientAge: 47, patientRequirements: "" , patientAllergies: "Citrus Fruits", patientNotes: "hypochondriac" ),
            new Patient(patientId: _nextId++, patientName: "Gertrude", patientGender: "F", patientAge: 82, patientRequirements: "Requires frequent check in's" , patientAllergies: "", patientNotes: "Doesn't want to be seen by male nurses, combative" )
        };

        public List<Patient> GetAll()
        {
            List<Patient> patients = new List<Patient>(Patients);
            return patients;
        }


        public Patient GetByPatientNumber(int PatientId)
        {
            return Patients.Find(patient => patient.PatientId == PatientId);
        }

        public Patient Add(Patient newPatient)
        {
            newPatient.PatientId = _nextId++;
            Patients.Add(newPatient);
            return newPatient;
        }
    }
}
