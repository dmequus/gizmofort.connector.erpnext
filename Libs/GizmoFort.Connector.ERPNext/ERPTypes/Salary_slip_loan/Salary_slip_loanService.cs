using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_slip_loan
{
    public class Salary_slip_loanService : SubServiceBase<ERPSalary_slip_loan>
    {
        public Salary_slip_loanService(ERPNextClient client)
            : base(DocType.Salary_slip_loan, client) { }

        protected override ERPSalary_slip_loan fromERPObject(ERPObject obj)
        {
            return new ERPSalary_slip_loan(obj);
        }
    }
}