using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Appraisal_goal
{
    public class Appraisal_goalService : SubServiceBase<ERPAppraisal_goal>
    {
        public Appraisal_goalService(ERPNextClient client)
            : base(DocType.Appraisal_goal, client) { }

        protected override ERPAppraisal_goal fromERPObject(ERPObject obj)
        {
            return new ERPAppraisal_goal(obj);
        }
    }
}