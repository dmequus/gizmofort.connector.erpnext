using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_website_specification
{
    public class Item_website_specificationService : SubServiceBase<ERPItem_website_specification>
    {
        public Item_website_specificationService(ERPNextClient client)
            : base(DocType.Item_website_specification, client) { }

        protected override ERPItem_website_specification fromERPObject(ERPObject obj)
        {
            return new ERPItem_website_specification(obj);
        }
    }
}