using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier
{
    public class SupplierService : SubServiceBase<ERPSupplier>
    {
        public SupplierService(ERPNextClient client)
            : base(DocType.Supplier, client) { }

        protected override ERPSupplier fromERPObject(ERPObject obj)
        {
            return new ERPSupplier(obj);
        }
    }
}