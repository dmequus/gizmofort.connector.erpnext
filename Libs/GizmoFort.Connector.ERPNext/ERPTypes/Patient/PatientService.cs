using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient
{
    public class PatientService : SubServiceBase<ERPPatient>
    {
        public PatientService(ERPNextClient client)
            : base(DocType.Patient, client) { }

        protected override ERPPatient fromERPObject(ERPObject obj)
        {
            return new ERPPatient(obj);
        }
    }
}