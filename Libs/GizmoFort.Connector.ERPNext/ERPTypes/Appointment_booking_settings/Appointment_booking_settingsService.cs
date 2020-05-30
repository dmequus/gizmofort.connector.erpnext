using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment_booking_settings
{
    public class Appointment_booking_settingsService : SubServiceBase<ERPAppointment_booking_settings>
    {
        public Appointment_booking_settingsService(ERPNextClient client)
            : base(DocType.Appointment_booking_settings, client) { }

        protected override ERPAppointment_booking_settings fromERPObject(ERPObject obj)
        {
            return new ERPAppointment_booking_settings(obj);
        }
    }
}