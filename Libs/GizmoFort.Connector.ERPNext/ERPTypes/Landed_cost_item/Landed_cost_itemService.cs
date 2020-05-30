using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Landed_cost_item
{
    public class Landed_cost_itemService : SubServiceBase<ERPLanded_cost_item>
    {
        public Landed_cost_itemService(ERPNextClient client)
            : base(DocType.Landed_cost_item, client) { }

        protected override ERPLanded_cost_item fromERPObject(ERPObject obj)
        {
            return new ERPLanded_cost_item(obj);
        }
    }
}