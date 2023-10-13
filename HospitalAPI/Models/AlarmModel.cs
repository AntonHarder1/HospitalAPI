namespace HospitalAPI.Models
{
    public class Alarm
    {
        public int DeviceId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int PatientId { get; set; }
        public int RoomNumber { get; set; }
        public string ServiceMessage { get; set; }

        public Alarm(int deviceId, string name, string status, int patientId, int roomNumber, string serviceMessage)
        {
            DeviceId = deviceId;
            Name = name;
            Status = status;
            PatientId = patientId;
            RoomNumber = roomNumber;
            ServiceMessage = serviceMessage;
        }
        public Alarm()
        {

        }
    }
}
