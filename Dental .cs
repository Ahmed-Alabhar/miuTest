namespace miuTest
{
    public class Patient
    {
        int patientId;
        string patientNumber;
        string firstName;
        string lastName;
        DateTime dateOfBirth;

        public int PatientId
        { get { return patientId; } set { patientId = value; } }
        public string PatientNumber
        { get { return patientNumber; } set { patientNumber = value; } }

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public DateTime DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }


        public Patient(int _patientId, string _patientNumber, string _firstName, string _lastName, DateTime _dateOfBirth)
        {
            PatientId = _patientId;
            PatientNumber = _patientNumber;
            FirstName = _firstName;
            LastName = _lastName;
            DateOfBirth = _dateOfBirth;
        }
    }

    public class Appointment
    {
        long appointmentId;
        DateTime appointmentDate_time;
        string dentistName; // optional
        string surgeryLocation; // optional
        Patient patient;

        public long AppointmentId
        { get { return appointmentId; } set { appointmentId = value; } }
        public DateTime AppointmentDate_time { get { return appointmentDate_time; } set { appointmentDate_time = value; } }
        public string DentistName { get { return dentistName; } set { dentistName = value; } }
        public string SurgeryLocation
        { get { return surgeryLocation; } set { surgeryLocation = value; } }
        public Patient AppointedPatient
        {
            get { return patient; } set {  patient = value; }
        }

        public Appointment(long _appointmentId, DateTime _appointmentDate_time, string _dentistName, string _surgeryLocation, Patient _patient)
        {
            AppointmentId = _appointmentId;
            AppointmentDate_time = _appointmentDate_time;
            DentistName = _dentistName;
            SurgeryLocation = _surgeryLocation;
            AppointedPatient = _patient;
        }

        public Appointment(long _appointmentId, DateTime _appointmentDate_time, string _dentistName, Patient _patient)
        {
            AppointmentId = _appointmentId;
            AppointmentDate_time = _appointmentDate_time;
            DentistName = _dentistName;
            AppointedPatient = _patient;

        }
        public Appointment(long _appointmentId, DateTime _appointmentDate_time, Patient _patient)
        {
            AppointmentId = _appointmentId;
            AppointmentDate_time = _appointmentDate_time;
            AppointedPatient = _patient;


        }
    }


}


//        Patient: 

//patientId: integer, (Primary Key field)

//patientNumber, (required field) (e.g.P101, EP117 etc.)

//firstName, (required field) (e.g.Bob, Anna, Carlos etc.)

//lastName, (required field) (e.g.Jones, Smith etc.)

//dateOfBirth, (required field) (e.g. 1997-12-18, 1958-03-27 etc.)



//Appointment: 
//appointmentId: long (Primary Key field)
//appointmentDate, REQUIRED(e.g. 2014-09-21, 2013-10-19, etc.)
//appointmentTime, REQUIRED(e.g. 10:00:00, 14:15:00 etc.)
//dentistName: (optional field) (e.g.Mary Long, David Pearson etc.)
//surgeryLocation, (optional field)