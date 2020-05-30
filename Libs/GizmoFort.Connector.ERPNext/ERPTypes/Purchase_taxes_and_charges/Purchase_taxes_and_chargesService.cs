using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_taxes_and_charges
{
    public class Purchase_taxes_and_chargesService : SubServiceBase<ERPPurchase_taxes_and_charges>
    {
        public Purchase_taxes_and_chargesService(ERPNextClient client)
            : base(DocType.Purchase_taxes_and_charges, client) { }

        protected override ERPPurchase_taxes_and_charges fromERPObject(ERPObject obj)
        {
            return new ERPPurchase_taxes_and_charges(obj);
        }
    }
}