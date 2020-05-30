using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_order_entry
{
    public class Restaurant_order_entryService : SubServiceBase<ERPRestaurant_order_entry>
    {
        public Restaurant_order_entryService(ERPNextClient client)
            : base(DocType.Restaurant_order_entry, client) { }

        protected override ERPRestaurant_order_entry fromERPObject(ERPObject obj)
        {
            return new ERPRestaurant_order_entry(obj);
        }
    }
}