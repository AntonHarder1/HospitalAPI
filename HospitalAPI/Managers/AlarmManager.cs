using HospitalAPI.Models;

namespace HospitalAPI.Managers
{
    public class AlarmManager
    {
        private static int _nextId = 1;

        private static readonly List<Alarm> Alarms = new List<Alarm>
        {
            new Alarm(deviceId: _nextId++, name: "Enuresis Alarm", status: "Pending", patientId: 11, roomNumber: 40, serviceMessage: "Skiftede defekt alarm"),
            new Alarm(deviceId: _nextId++, name: "Enuresis Alarm", status: "Active", patientId: 12, roomNumber: 42, serviceMessage: "Skiftede defekt alarm"),
            new Alarm(deviceId: _nextId++, name: "Enuresis Alarm", status: "Alert", patientId: 13, roomNumber: 44, serviceMessage: "Skiftede defekt alarm"),
        };

        public List<Alarm> GetAll()
        {
            List<Alarm> alarms = new List<Alarm>(Alarms);
            return alarms;
        }

        public Alarm? GetByAlarmNumber(int AlarmNumber)
        {
            return Alarms.Find(Alarm => Alarm.DeviceId == AlarmNumber);
        }

        public Alarm Add(Alarm newAlarm)
        {
            newAlarm.DeviceId = _nextId++;
            Alarms.Add(newAlarm);
            return newAlarm;
        }

    }
}
