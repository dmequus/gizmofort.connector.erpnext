using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Warehouse_type
{
    public class Warehouse_typeService : SubServiceBase<ERPWarehouse_type>
    {
        public Warehouse_typeService(ERPNextClient client)
            : base(DocType.Warehouse_type, client) { }

        protected override ERPWarehouse_type fromERPObject(ERPObject obj)
        {
            return new ERPWarehouse_type(obj);
        }
    }
}