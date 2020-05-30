using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_taxes_and_charges_template
{
    public class Purchase_taxes_and_charges_templateService : SubServiceBase<ERPPurchase_taxes_and_charges_template>
    {
        public Purchase_taxes_and_charges_templateService(ERPNextClient client)
            : base(DocType.Purchase_taxes_and_charges_template, client) { }

        protected override ERPPurchase_taxes_and_charges_template fromERPObject(ERPObject obj)
        {
            return new ERPPurchase_taxes_and_charges_template(obj);
        }
    }
}