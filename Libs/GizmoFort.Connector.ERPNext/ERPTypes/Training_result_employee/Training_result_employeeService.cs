using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Training_result_employee
{
    public class Training_result_employeeService : SubServiceBase<ERPTraining_result_employee>
    {
        public Training_result_employeeService(ERPNextClient client)
            : base(DocType.Training_result_employee, client) { }

        protected override ERPTraining_result_employee fromERPObject(ERPObject obj)
        {
            return new ERPTraining_result_employee(obj);
        }
    }
}