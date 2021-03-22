using GenericRepository.Model;
using System;
using System.Linq;

namespace GenericRepository
{
    public class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
    {
        public IQueryable<object> GetAppointmentsCountByDate(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IQueryable<object> GetAppointmentsCountByServiceNames(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IQueryable<object> GetAppointmentsIncomeByServiceNames(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
