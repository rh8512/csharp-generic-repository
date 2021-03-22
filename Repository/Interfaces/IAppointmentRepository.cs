using GenericRepository.Model;
using System;
using System.Linq;

namespace GenericRepository
{
    interface IAppointmentRepository : IRepositoryBase<Appointment>
    {
        /* some additional method - specific to given repository*/
        IQueryable<object> GetAppointmentsCountByServiceNames(DateTime start, DateTime end);
        IQueryable<object> GetAppointmentsCountByDate(DateTime start, DateTime end);
        IQueryable<object> GetAppointmentsIncomeByServiceNames(DateTime start, DateTime end);
    }
}