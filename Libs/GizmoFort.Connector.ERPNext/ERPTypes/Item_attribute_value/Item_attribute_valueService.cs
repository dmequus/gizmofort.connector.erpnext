using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_attribute_value
{
    public class Item_attribute_valueService : SubServiceBase<ERPItem_attribute_value>
    {
        public Item_attribute_valueService(ERPNextClient client)
            : base(DocType.Item_attribute_value, client) { }

        protected override ERPItem_attribute_value fromERPObject(ERPObject obj)
        {
            return new ERPItem_attribute_value(obj);
        }
    }
}