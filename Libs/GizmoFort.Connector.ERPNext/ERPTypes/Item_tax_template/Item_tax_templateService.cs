using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_tax_template
{
    public class Item_tax_templateService : SubServiceBase<ERPItem_tax_template>
    {
        public Item_tax_templateService(ERPNextClient client)
            : base(DocType.Item_tax_template, client) { }

        protected override ERPItem_tax_template fromERPObject(ERPObject obj)
        {
            return new ERPItem_tax_template(obj);
        }
    }
}