using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_taxes_and_charges
{
    public class Sales_taxes_and_chargesService : SubServiceBase<ERPSales_taxes_and_charges>
    {
        public Sales_taxes_and_chargesService(ERPNextClient client)
            : base(DocType.Sales_taxes_and_charges, client) { }

        protected override ERPSales_taxes_and_charges fromERPObject(ERPObject obj)
        {
            return new ERPSales_taxes_and_charges(obj);
        }
    }
}