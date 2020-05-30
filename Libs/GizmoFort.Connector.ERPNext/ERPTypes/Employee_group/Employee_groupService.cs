using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_group
{
    public class Employee_groupService : SubServiceBase<ERPEmployee_group>
    {
        public Employee_groupService(ERPNextClient client)
            : base(DocType.Employee_group, client) { }

        protected override ERPEmployee_group fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_group(obj);
        }
    }
}