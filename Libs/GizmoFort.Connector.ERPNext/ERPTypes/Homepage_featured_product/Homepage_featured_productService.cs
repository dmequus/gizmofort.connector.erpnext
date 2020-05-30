using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Homepage_featured_product
{
    public class Homepage_featured_productService : SubServiceBase<ERPHomepage_featured_product>
    {
        public Homepage_featured_productService(ERPNextClient client)
            : base(DocType.Homepage_featured_product, client) { }

        protected override ERPHomepage_featured_product fromERPObject(ERPObject obj)
        {
            return new ERPHomepage_featured_product(obj);
        }
    }
}