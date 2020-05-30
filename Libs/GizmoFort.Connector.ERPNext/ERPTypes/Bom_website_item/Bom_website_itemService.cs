using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_website_item
{
    public class Bom_website_itemService : SubServiceBase<ERPBom_website_item>
    {
        public Bom_website_itemService(ERPNextClient client)
            : base(DocType.Bom_website_item, client) { }

        protected override ERPBom_website_item fromERPObject(ERPObject obj)
        {
            return new ERPBom_website_item(obj);
        }
    }
}