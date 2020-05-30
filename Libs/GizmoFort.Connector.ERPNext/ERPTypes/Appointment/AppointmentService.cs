using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment
{
    public class AppointmentService : SubServiceBase<ERPAppointment>
    {
        public AppointmentService(ERPNextClient client)
            : base(DocType.Appointment, client) { }

        protected override ERPAppointment fromERPObject(ERPObject obj)
        {
            return new ERPAppointment(obj);
        }
    }
}