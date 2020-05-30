using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment_template
{
    public class Patient_assessment_templateService : SubServiceBase<ERPPatient_assessment_template>
    {
        public Patient_assessment_templateService(ERPNextClient client)
            : base(DocType.Patient_assessment_template, client) { }

        protected override ERPPatient_assessment_template fromERPObject(ERPObject obj)
        {
            return new ERPPatient_assessment_template(obj);
        }
    }
}