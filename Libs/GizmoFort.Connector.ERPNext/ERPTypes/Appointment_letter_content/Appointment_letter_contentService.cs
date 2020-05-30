using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment_letter_content
{
    public class Appointment_letter_contentService : SubServiceBase<ERPAppointment_letter_content>
    {
        public Appointment_letter_contentService(ERPNextClient client)
            : base(DocType.Appointment_letter_content, client) { }

        protected override ERPAppointment_letter_content fromERPObject(ERPObject obj)
        {
            return new ERPAppointment_letter_content(obj);
        }
    }
}