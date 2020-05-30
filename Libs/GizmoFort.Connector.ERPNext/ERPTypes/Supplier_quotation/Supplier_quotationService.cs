using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_quotation
{
    public class Supplier_quotationService : SubServiceBase<ERPSupplier_quotation>
    {
        public Supplier_quotationService(ERPNextClient client)
            : base(DocType.Supplier_quotation, client) { }

        protected override ERPSupplier_quotation fromERPObject(ERPObject obj)
        {
            return new ERPSupplier_quotation(obj);
        }
    }
}