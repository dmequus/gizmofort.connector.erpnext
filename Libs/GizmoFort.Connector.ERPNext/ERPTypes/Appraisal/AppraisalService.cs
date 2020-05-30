using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Appraisal
{
    public class AppraisalService : SubServiceBase<ERPAppraisal>
    {
        public AppraisalService(ERPNextClient client)
            : base(DocType.Appraisal, client) { }

        protected override ERPAppraisal fromERPObject(ERPObject obj)
        {
            return new ERPAppraisal(obj);
        }
    }
}