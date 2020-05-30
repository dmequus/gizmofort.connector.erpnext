using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_group_table
{
    public class Employee_group_tableService : SubServiceBase<ERPEmployee_group_table>
    {
        public Employee_group_tableService(ERPNextClient client)
            : base(DocType.Employee_group_table, client) { }

        protected override ERPEmployee_group_table fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_group_table(obj);
        }
    }
}