using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Appraisal_template
{
    public class Appraisal_templateService : SubServiceBase<ERPAppraisal_template>
    {
        public Appraisal_templateService(ERPNextClient client)
            : base(DocType.Appraisal_template, client) { }

        protected override ERPAppraisal_template fromERPObject(ERPObject obj)
        {
            return new ERPAppraisal_template(obj);
        }
    }
}