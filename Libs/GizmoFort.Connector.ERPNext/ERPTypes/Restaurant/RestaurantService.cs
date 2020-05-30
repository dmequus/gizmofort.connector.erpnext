using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant
{
    public class RestaurantService : SubServiceBase<ERPRestaurant>
    {
        public RestaurantService(ERPNextClient client)
            : base(DocType.Restaurant, client) { }

        protected override ERPRestaurant fromERPObject(ERPObject obj)
        {
            return new ERPRestaurant(obj);
        }
    }
}