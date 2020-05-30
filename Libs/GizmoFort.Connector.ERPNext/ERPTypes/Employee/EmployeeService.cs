using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee
{
    public class EmployeeService : SubServiceBase<ERPEmployee>
    {
        public EmployeeService(ERPNextClient client)
            : base(DocType.Employee, client) { }

        protected override ERPEmployee fromERPObject(ERPObject obj)
        {
            return new ERPEmployee(obj);
        }
    }
}