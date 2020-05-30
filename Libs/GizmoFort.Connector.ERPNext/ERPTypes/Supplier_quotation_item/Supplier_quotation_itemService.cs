using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_quotation_item
{
    public class Supplier_quotation_itemService : SubServiceBase<ERPSupplier_quotation_item>
    {
        public Supplier_quotation_itemService(ERPNextClient client)
            : base(DocType.Supplier_quotation_item, client) { }

        protected override ERPSupplier_quotation_item fromERPObject(ERPObject obj)
        {
            return new ERPSupplier_quotation_item(obj);
        }
    }
}