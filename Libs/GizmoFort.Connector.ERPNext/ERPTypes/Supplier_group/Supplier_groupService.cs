using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_group
{
    public class Supplier_groupService : SubServiceBase<ERPSupplier_group>
    {
        public Supplier_groupService(ERPNextClient client)
            : base(DocType.Supplier_group, client) { }

        protected override ERPSupplier_group fromERPObject(ERPObject obj)
        {
            return new ERPSupplier_group(obj);
        }
    }
}