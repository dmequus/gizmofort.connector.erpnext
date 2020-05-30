using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payroll_period_date
{
    public class Payroll_period_dateService : SubServiceBase<ERPPayroll_period_date>
    {
        public Payroll_period_dateService(ERPNextClient client)
            : base(DocType.Payroll_period_date, client) { }

        protected override ERPPayroll_period_date fromERPObject(ERPObject obj)
        {
            return new ERPPayroll_period_date(obj);
        }
    }
}