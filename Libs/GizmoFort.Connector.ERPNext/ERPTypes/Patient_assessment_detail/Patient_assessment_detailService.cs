using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment_detail
{
    public class Patient_assessment_detailService : SubServiceBase<ERPPatient_assessment_detail>
    {
        public Patient_assessment_detailService(ERPNextClient client)
            : base(DocType.Patient_assessment_detail, client) { }

        protected override ERPPatient_assessment_detail fromERPObject(ERPObject obj)
        {
            return new ERPPatient_assessment_detail(obj);
        }
    }
}