using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_internal_work_history
{
    public class Employee_internal_work_historyService : SubServiceBase<ERPEmployee_internal_work_history>
    {
        public Employee_internal_work_historyService(ERPNextClient client)
            : base(DocType.Employee_internal_work_history, client) { }

        protected override ERPEmployee_internal_work_history fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_internal_work_history(obj);
        }
    }
}