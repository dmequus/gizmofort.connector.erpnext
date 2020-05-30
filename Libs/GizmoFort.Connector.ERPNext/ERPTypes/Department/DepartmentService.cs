using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Department
{
    public class DepartmentService : SubServiceBase<ERPDepartment>
    {
        public DepartmentService(ERPNextClient client)
            : base(DocType.Department, client) { }

        protected override ERPDepartment fromERPObject(ERPObject obj)
        {
            return new ERPDepartment(obj);
        }
    }
}