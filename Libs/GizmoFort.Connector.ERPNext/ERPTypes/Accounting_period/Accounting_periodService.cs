using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounting_period
{
    public class Accounting_periodService : SubServiceBase<ERPAccounting_period>
    {
        public Accounting_periodService(ERPNextClient client)
            : base(DocType.Accounting_period, client) { }

        protected override ERPAccounting_period fromERPObject(ERPObject obj)
        {
            return new ERPAccounting_period(obj);
        }
    }
}