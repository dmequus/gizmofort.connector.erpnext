using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_tax_template_detail
{
    public class Item_tax_template_detailService : SubServiceBase<ERPItem_tax_template_detail>
    {
        public Item_tax_template_detailService(ERPNextClient client)
            : base(DocType.Item_tax_template_detail, client) { }

        protected override ERPItem_tax_template_detail fromERPObject(ERPObject obj)
        {
            return new ERPItem_tax_template_detail(obj);
        }
    }
}