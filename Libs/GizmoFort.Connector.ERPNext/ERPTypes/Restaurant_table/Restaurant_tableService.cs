using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_table
{
    public class Restaurant_tableService : SubServiceBase<ERPRestaurant_table>
    {
        public Restaurant_tableService(ERPNextClient client)
            : base(DocType.Restaurant_table, client) { }

        protected override ERPRestaurant_table fromERPObject(ERPObject obj)
        {
            return new ERPRestaurant_table(obj);
        }
    }
}