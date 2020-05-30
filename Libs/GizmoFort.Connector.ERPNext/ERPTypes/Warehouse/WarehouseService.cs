using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Warehouse
{
    public class WarehouseService : SubServiceBase<ERPWarehouse>
    {
        public WarehouseService(ERPNextClient client)
            : base(DocType.Warehouse, client) { }

        protected override ERPWarehouse fromERPObject(ERPObject obj)
        {
            return new ERPWarehouse(obj);
        }
    }
}