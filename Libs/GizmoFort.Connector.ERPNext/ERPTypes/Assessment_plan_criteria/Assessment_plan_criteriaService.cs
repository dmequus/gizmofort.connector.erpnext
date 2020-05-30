using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_plan_criteria
{
    public class Assessment_plan_criteriaService : SubServiceBase<ERPAssessment_plan_criteria>
    {
        public Assessment_plan_criteriaService(ERPNextClient client)
            : base(DocType.Assessment_plan_criteria, client) { }

        protected override ERPAssessment_plan_criteria fromERPObject(ERPObject obj)
        {
            return new ERPAssessment_plan_criteria(obj);
        }
    }
}