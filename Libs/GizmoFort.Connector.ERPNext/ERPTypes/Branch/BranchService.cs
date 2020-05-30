using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Branch
{
    public class BranchService : SubServiceBase<ERPBranch>
    {
        public BranchService(ERPNextClient client)
            : base(DocType.Branch, client) { }

        protected override ERPBranch fromERPObject(ERPObject obj)
        {
            return new ERPBranch(obj);
        }
    }
}