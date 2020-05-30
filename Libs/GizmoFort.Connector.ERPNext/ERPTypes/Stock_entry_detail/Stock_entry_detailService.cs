using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_entry_detail
{
    public class Stock_entry_detailService : SubServiceBase<ERPStock_entry_detail>
    {
        public Stock_entry_detailService(ERPNextClient client)
            : base(DocType.Stock_entry_detail, client) { }

        protected override ERPStock_entry_detail fromERPObject(ERPObject obj)
        {
            return new ERPStock_entry_detail(obj);
        }
    }
}