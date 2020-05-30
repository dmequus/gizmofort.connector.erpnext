using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_price
{
    public class Item_priceService : SubServiceBase<ERPItem_price>
    {
        public Item_priceService(ERPNextClient client)
            : base(DocType.Item_price, client) { }

        protected override ERPItem_price fromERPObject(ERPObject obj)
        {
            return new ERPItem_price(obj);
        }
    }
}