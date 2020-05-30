using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_variant
{
    public class Item_variantService : SubServiceBase<ERPItem_variant>
    {
        public Item_variantService(ERPNextClient client)
            : base(DocType.Item_variant, client) { }

        protected override ERPItem_variant fromERPObject(ERPObject obj)
        {
            return new ERPItem_variant(obj);
        }
    }
}