using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_manufacturer
{
    public class Item_manufacturerService : SubServiceBase<ERPItem_manufacturer>
    {
        public Item_manufacturerService(ERPNextClient client)
            : base(DocType.Item_manufacturer, client) { }

        protected override ERPItem_manufacturer fromERPObject(ERPObject obj)
        {
            return new ERPItem_manufacturer(obj);
        }
    }
}