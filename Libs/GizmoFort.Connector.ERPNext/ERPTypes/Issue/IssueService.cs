using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Issue
{
    public class IssueService : SubServiceBase<ERPIssue>
    {
        public IssueService(ERPNextClient client)
            : base(DocType.Issue, client) { }

        protected override ERPIssue fromERPObject(ERPObject obj)
        {
            return new ERPIssue(obj);
        }
    }
}