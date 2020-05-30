using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_variant_attribute
{
    public class Item_variant_attributeService : SubServiceBase<ERPItem_variant_attribute>
    {
        public Item_variant_attributeService(ERPNextClient client)
            : base(DocType.Item_variant_attribute, client) { }

        protected override ERPItem_variant_attribute fromERPObject(ERPObject obj)
        {
            return new ERPItem_variant_attribute(obj);
        }
    }
}