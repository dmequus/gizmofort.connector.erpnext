using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_property_history
{
    public class Employee_property_historyService : SubServiceBase<ERPEmployee_property_history>
    {
        public Employee_property_historyService(ERPNextClient client)
            : base(DocType.Employee_property_history, client) { }

        protected override ERPEmployee_property_history fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_property_history(obj);
        }
    }
}