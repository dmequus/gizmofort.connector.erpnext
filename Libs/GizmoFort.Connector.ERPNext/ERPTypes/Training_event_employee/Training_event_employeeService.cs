using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Training_event_employee
{
    public class Training_event_employeeService : SubServiceBase<ERPTraining_event_employee>
    {
        public Training_event_employeeService(ERPNextClient client)
            : base(DocType.Training_event_employee, client) { }

        protected override ERPTraining_event_employee fromERPObject(ERPObject obj)
        {
            return new ERPTraining_event_employee(obj);
        }
    }
}