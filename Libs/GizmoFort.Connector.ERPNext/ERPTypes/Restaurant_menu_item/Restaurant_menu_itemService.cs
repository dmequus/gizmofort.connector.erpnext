using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_menu_item
{
    public class Restaurant_menu_itemService : SubServiceBase<ERPRestaurant_menu_item>
    {
        public Restaurant_menu_itemService(ERPNextClient client)
            : base(DocType.Restaurant_menu_item, client) { }

        protected override ERPRestaurant_menu_item fromERPObject(ERPObject obj)
        {
            return new ERPRestaurant_menu_item(obj);
        }
    }
}