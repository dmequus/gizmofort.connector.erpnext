using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_criteria_group
{
    public class Assessment_criteria_groupService : SubServiceBase<ERPAssessment_criteria_group>
    {
        public Assessment_criteria_groupService(ERPNextClient client)
            : base(DocType.Assessment_criteria_group, client) { }

        protected override ERPAssessment_criteria_group fromERPObject(ERPObject obj)
        {
            return new ERPAssessment_criteria_group(obj);
        }
    }
}