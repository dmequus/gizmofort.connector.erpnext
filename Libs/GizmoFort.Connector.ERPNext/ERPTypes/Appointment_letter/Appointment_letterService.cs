using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment_letter
{
    public class Appointment_letterService : SubServiceBase<ERPAppointment_letter>
    {
        public Appointment_letterService(ERPNextClient client)
            : base(DocType.Appointment_letter, client) { }

        protected override ERPAppointment_letter fromERPObject(ERPObject obj)
        {
            return new ERPAppointment_letter(obj);
        }
    }
}