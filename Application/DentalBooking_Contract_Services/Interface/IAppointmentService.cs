using DentalBooking.Contract.Repository.Entity;
using DentalBooking.ModelViews.AppointmentModelViews;

namespace DentalBooking_Contract_Services.Interface
{
    public interface IAppointmentService
    {
        Task<IEnumerable<AppointmentResponeModelViews>> GetAllAppointmentsAsync();
        Task<IEnumerable<AppointmentResponeModelViews>> AllAppointmentsByUserIdAsync(int UserId);
        Task<AppointmentResponeModelViews> GetAppointmentByIdAsync(int id);
        Task<AppointmentResponeModelViews> CreateAppointmentAsync(AppointmentRequestModelView model);
        Task<IEnumerable<Appointment>> GetAppointmentsByDentistIdAsync(int dentistId);
        Task<List<AppointmentResponeModelViews>> GetWeeklyScheduleForDentist(int dentistId);
        Task<bool> UpdateAppointmentAsync(int id, AppointmentRequestModelView model);
        Task<bool> DeleteAppointmentAsync(int id);
        Task<List<AppointmentResponeModelViews>> BookPeriodicAppointmentsAsync(AppointmentRequestModelView model, int months);
        Task<IEnumerable<AppointmentResponeModelViews>> AlertAppointmentDayAfter(int userId, bool isAlert);
        Task<IEnumerable<Appointment>> GetPaginatedAppointmentsAsync(int pageNumber, int pageSize);
        Task<double> GetTotalAppointmentsCountAsync();
    }
}
