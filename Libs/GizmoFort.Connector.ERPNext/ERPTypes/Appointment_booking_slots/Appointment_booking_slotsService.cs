using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment_booking_slots
{
    public class Appointment_booking_slotsService : SubServiceBase<ERPAppointment_booking_slots>
    {
        public Appointment_booking_slotsService(ERPNextClient client)
            : base(DocType.Appointment_booking_slots, client) { }

        protected override ERPAppointment_booking_slots fromERPObject(ERPObject obj)
        {
            return new ERPAppointment_booking_slots(obj);
        }
    }
}