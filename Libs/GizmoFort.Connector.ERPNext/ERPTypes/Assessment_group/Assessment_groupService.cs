using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_group
{
    public class Assessment_groupService : SubServiceBase<ERPAssessment_group>
    {
        public Assessment_groupService(ERPNextClient client)
            : base(DocType.Assessment_group, client) { }

        protected override ERPAssessment_group fromERPObject(ERPObject obj)
        {
            return new ERPAssessment_group(obj);
        }
    }
}