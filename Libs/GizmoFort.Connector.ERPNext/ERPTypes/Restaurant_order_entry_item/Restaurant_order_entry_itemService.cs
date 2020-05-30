using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_order_entry_item
{
    public class Restaurant_order_entry_itemService : SubServiceBase<ERPRestaurant_order_entry_item>
    {
        public Restaurant_order_entry_itemService(ERPNextClient client)
            : base(DocType.Restaurant_order_entry_item, client) { }

        protected override ERPRestaurant_order_entry_item fromERPObject(ERPObject obj)
        {
            return new ERPRestaurant_order_entry_item(obj);
        }
    }
}