using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payroll_entry
{
    public class Payroll_entryService : SubServiceBase<ERPPayroll_entry>
    {
        public Payroll_entryService(ERPNextClient client)
            : base(DocType.Payroll_entry, client) { }

        protected override ERPPayroll_entry fromERPObject(ERPObject obj)
        {
            return new ERPPayroll_entry(obj);
        }
    }
}