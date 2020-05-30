using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Appraisal_template_goal
{
    public class Appraisal_template_goalService : SubServiceBase<ERPAppraisal_template_goal>
    {
        public Appraisal_template_goalService(ERPNextClient client)
            : base(DocType.Appraisal_template_goal, client) { }

        protected override ERPAppraisal_template_goal fromERPObject(ERPObject obj)
        {
            return new ERPAppraisal_template_goal(obj);
        }
    }
}