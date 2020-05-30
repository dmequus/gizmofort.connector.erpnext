using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Product_bundle
{
    public class Product_bundleService : SubServiceBase<ERPProduct_bundle>
    {
        public Product_bundleService(ERPNextClient client)
            : base(DocType.Product_bundle, client) { }

        protected override ERPProduct_bundle fromERPObject(ERPObject obj)
        {
            return new ERPProduct_bundle(obj);
        }
    }
}