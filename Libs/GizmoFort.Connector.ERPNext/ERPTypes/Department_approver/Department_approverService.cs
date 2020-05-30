using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Department_approver
{
    public class Department_approverService : SubServiceBase<ERPDepartment_approver>
    {
        public Department_approverService(ERPNextClient client)
            : base(DocType.Department_approver, client) { }

        protected override ERPDepartment_approver fromERPObject(ERPObject obj)
        {
            return new ERPDepartment_approver(obj);
        }
    }
}