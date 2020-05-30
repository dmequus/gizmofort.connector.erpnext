using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shipping_rule_country
{
    public class Shipping_rule_countryService : SubServiceBase<ERPShipping_rule_country>
    {
        public Shipping_rule_countryService(ERPNextClient client)
            : base(DocType.Shipping_rule_country, client) { }

        protected override ERPShipping_rule_country fromERPObject(ERPObject obj)
        {
            return new ERPShipping_rule_country(obj);
        }
    }
}