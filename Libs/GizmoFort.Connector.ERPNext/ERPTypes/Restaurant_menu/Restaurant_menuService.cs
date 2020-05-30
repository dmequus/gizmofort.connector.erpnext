using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_menu
{
    public class Restaurant_menuService : SubServiceBase<ERPRestaurant_menu>
    {
        public Restaurant_menuService(ERPNextClient client)
            : base(DocType.Restaurant_menu, client) { }

        protected override ERPRestaurant_menu fromERPObject(ERPObject obj)
        {
            return new ERPRestaurant_menu(obj);
        }
    }
}