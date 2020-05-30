using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_appointment
{
    public class Patient_appointmentService : SubServiceBase<ERPPatient_appointment>
    {
        public Patient_appointmentService(ERPNextClient client)
            : base(DocType.Patient_appointment, client) { }

        protected override ERPPatient_appointment fromERPObject(ERPObject obj)
        {
            return new ERPPatient_appointment(obj);
        }
    }
}