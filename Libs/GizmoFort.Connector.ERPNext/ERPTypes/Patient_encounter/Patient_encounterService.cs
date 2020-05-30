using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_encounter
{
    public class Patient_encounterService : SubServiceBase<ERPPatient_encounter>
    {
        public Patient_encounterService(ERPNextClient client)
            : base(DocType.Patient_encounter, client) { }

        protected override ERPPatient_encounter fromERPObject(ERPObject obj)
        {
            return new ERPPatient_encounter(obj);
        }
    }
}