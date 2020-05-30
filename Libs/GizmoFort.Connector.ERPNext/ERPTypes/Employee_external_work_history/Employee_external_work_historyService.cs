using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_external_work_history
{
    public class Employee_external_work_historyService : SubServiceBase<ERPEmployee_external_work_history>
    {
        public Employee_external_work_historyService(ERPNextClient client)
            : base(DocType.Employee_external_work_history, client) { }

        protected override ERPEmployee_external_work_history fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_external_work_history(obj);
        }
    }
}