using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Diagnosis
{
    public class DiagnosisService : SubServiceBase<ERPDiagnosis>
    {
        public DiagnosisService(ERPNextClient client)
            : base(DocType.Diagnosis, client) { }

        protected override ERPDiagnosis fromERPObject(ERPObject obj)
        {
            return new ERPDiagnosis(obj);
        }
    }
}