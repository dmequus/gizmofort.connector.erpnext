using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Promotional_scheme_price_discount
{
    public class Promotional_scheme_price_discountService : SubServiceBase<ERPPromotional_scheme_price_discount>
    {
        public Promotional_scheme_price_discountService(ERPNextClient client)
            : base(DocType.Promotional_scheme_price_discount, client) { }

        protected override ERPPromotional_scheme_price_discount fromERPObject(ERPObject obj)
        {
            return new ERPPromotional_scheme_price_discount(obj);
        }
    }
}