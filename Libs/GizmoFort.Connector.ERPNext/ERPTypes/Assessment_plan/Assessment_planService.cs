using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_plan
{
    public class Assessment_planService : SubServiceBase<ERPAssessment_plan>
    {
        public Assessment_planService(ERPNextClient client)
            : base(DocType.Assessment_plan, client) { }

        protected override ERPAssessment_plan fromERPObject(ERPObject obj)
        {
            return new ERPAssessment_plan(obj);
        }
    }
}