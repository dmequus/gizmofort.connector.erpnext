using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment_type
{
    public class Appointment_typeService : SubServiceBase<ERPAppointment_type>
    {
        public Appointment_typeService(ERPNextClient client)
            : base(DocType.Appointment_type, client) { }

        protected override ERPAppointment_type fromERPObject(ERPObject obj)
        {
            return new ERPAppointment_type(obj);
        }
    }
}