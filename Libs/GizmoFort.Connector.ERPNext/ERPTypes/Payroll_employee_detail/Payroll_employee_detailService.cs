using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payroll_employee_detail
{
    public class Payroll_employee_detailService : SubServiceBase<ERPPayroll_employee_detail>
    {
        public Payroll_employee_detailService(ERPNextClient client)
            : base(DocType.Payroll_employee_detail, client) { }

        protected override ERPPayroll_employee_detail fromERPObject(ERPObject obj)
        {
            return new ERPPayroll_employee_detail(obj);
        }
    }
}