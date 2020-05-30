using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_default
{
    public class Item_defaultService : SubServiceBase<ERPItem_default>
    {
        public Item_defaultService(ERPNextClient client)
            : base(DocType.Item_default, client) { }

        protected override ERPItem_default fromERPObject(ERPObject obj)
        {
            return new ERPItem_default(obj);
        }
    }
}