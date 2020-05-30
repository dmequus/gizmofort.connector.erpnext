using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_encounter_symptom
{
    public class Patient_encounter_symptomService : SubServiceBase<ERPPatient_encounter_symptom>
    {
        public Patient_encounter_symptomService(ERPNextClient client)
            : base(DocType.Patient_encounter_symptom, client) { }

        protected override ERPPatient_encounter_symptom fromERPObject(ERPObject obj)
        {
            return new ERPPatient_encounter_symptom(obj);
        }
    }
}