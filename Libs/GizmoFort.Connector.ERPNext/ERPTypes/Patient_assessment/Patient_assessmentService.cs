using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment
{
    public class Patient_assessmentService : SubServiceBase<ERPPatient_assessment>
    {
        public Patient_assessmentService(ERPNextClient client)
            : base(DocType.Patient_assessment, client) { }

        protected override ERPPatient_assessment fromERPObject(ERPObject obj)
        {
            return new ERPPatient_assessment(obj);
        }
    }
}