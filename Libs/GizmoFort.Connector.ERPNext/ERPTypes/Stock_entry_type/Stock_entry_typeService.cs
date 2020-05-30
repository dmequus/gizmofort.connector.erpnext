using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_entry_type
{
    public class Stock_entry_typeService : SubServiceBase<ERPStock_entry_type>
    {
        public Stock_entry_typeService(ERPNextClient client)
            : base(DocType.Stock_entry_type, client) { }

        protected override ERPStock_entry_type fromERPObject(ERPObject obj)
        {
            return new ERPStock_entry_type(obj);
        }
    }
}