using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Brand
{
    public class BrandService : SubServiceBase<ERPBrand>
    {
        public BrandService(ERPNextClient client)
            : base(DocType.Brand, client) { }

        protected override ERPBrand fromERPObject(ERPObject obj)
        {
            return new ERPBrand(obj);
        }
    }
}