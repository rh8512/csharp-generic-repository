using GenericRepository.Model;
using System;

namespace GenericRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            Appointment appointment = new();
            Patient patient = new();

            PatientRepository patientRepository = new();
            patientRepository.Save(patient);

            AppointmentRepository appointmentRepository = new();
            appointmentRepository.Save(appointment);
            appointmentRepository.GetAppointmentsCountByDate(DateTime.Now, DateTime.Now);
        }
    }
}
