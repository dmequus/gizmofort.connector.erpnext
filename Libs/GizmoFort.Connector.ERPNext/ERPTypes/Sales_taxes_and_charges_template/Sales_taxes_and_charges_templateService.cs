using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_taxes_and_charges_template
{
    public class Sales_taxes_and_charges_templateService : SubServiceBase<ERPSales_taxes_and_charges_template>
    {
        public Sales_taxes_and_charges_templateService(ERPNextClient client)
            : base(DocType.Sales_taxes_and_charges_template, client) { }

        protected override ERPSales_taxes_and_charges_template fromERPObject(ERPObject obj)
        {
            return new ERPSales_taxes_and_charges_template(obj);
        }
    }
}