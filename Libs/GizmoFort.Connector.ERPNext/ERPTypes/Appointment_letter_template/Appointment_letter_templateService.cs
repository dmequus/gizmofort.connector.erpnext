using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Appointment_letter_template
{
    public class Appointment_letter_templateService : SubServiceBase<ERPAppointment_letter_template>
    {
        public Appointment_letter_templateService(ERPNextClient client)
            : base(DocType.Appointment_letter_template, client) { }

        protected override ERPAppointment_letter_template fromERPObject(ERPObject obj)
        {
            return new ERPAppointment_letter_template(obj);
        }
    }
}