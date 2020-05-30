using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_encounter_diagnosis
{
    public class Patient_encounter_diagnosisService : SubServiceBase<ERPPatient_encounter_diagnosis>
    {
        public Patient_encounter_diagnosisService(ERPNextClient client)
            : base(DocType.Patient_encounter_diagnosis, client) { }

        protected override ERPPatient_encounter_diagnosis fromERPObject(ERPObject obj)
        {
            return new ERPPatient_encounter_diagnosis(obj);
        }
    }
}