using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Issue_type
{
    public class Issue_typeService : SubServiceBase<ERPIssue_type>
    {
        public Issue_typeService(ERPNextClient client)
            : base(DocType.Issue_type, client) { }

        protected override ERPIssue_type fromERPObject(ERPObject obj)
        {
            return new ERPIssue_type(obj);
        }
    }
}