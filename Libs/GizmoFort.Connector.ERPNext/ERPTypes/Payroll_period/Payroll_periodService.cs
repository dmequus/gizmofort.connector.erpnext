using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payroll_period
{
    public class Payroll_periodService : SubServiceBase<ERPPayroll_period>
    {
        public Payroll_periodService(ERPNextClient client)
            : base(DocType.Payroll_period, client) { }

        protected override ERPPayroll_period fromERPObject(ERPObject obj)
        {
            return new ERPPayroll_period(obj);
        }
    }
}