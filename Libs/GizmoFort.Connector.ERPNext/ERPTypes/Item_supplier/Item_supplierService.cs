using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_supplier
{
    public class Item_supplierService : SubServiceBase<ERPItem_supplier>
    {
        public Item_supplierService(ERPNextClient client)
            : base(DocType.Item_supplier, client) { }

        protected override ERPItem_supplier fromERPObject(ERPObject obj)
        {
            return new ERPItem_supplier(obj);
        }
    }
}