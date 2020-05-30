using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_attribute
{
    public class Item_attributeService : SubServiceBase<ERPItem_attribute>
    {
        public Item_attributeService(ERPNextClient client)
            : base(DocType.Item_attribute, client) { }

        protected override ERPItem_attribute fromERPObject(ERPObject obj)
        {
            return new ERPItem_attribute(obj);
        }
    }
}