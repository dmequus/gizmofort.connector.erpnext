using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_medical_record
{
    public class Patient_medical_recordService : SubServiceBase<ERPPatient_medical_record>
    {
        public Patient_medical_recordService(ERPNextClient client)
            : base(DocType.Patient_medical_record, client) { }

        protected override ERPPatient_medical_record fromERPObject(ERPObject obj)
        {
            return new ERPPatient_medical_record(obj);
        }
    }
}