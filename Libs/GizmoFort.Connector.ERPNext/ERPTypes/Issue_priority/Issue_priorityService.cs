using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Issue_priority
{
    public class Issue_priorityService : SubServiceBase<ERPIssue_priority>
    {
        public Issue_priorityService(ERPNextClient client)
            : base(DocType.Issue_priority, client) { }

        protected override ERPIssue_priority fromERPObject(ERPObject obj)
        {
            return new ERPIssue_priority(obj);
        }
    }
}