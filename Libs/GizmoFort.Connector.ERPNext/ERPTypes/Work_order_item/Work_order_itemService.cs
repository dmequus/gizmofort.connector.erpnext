using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Work_order_item
{
    public class Work_order_itemService : SubServiceBase<ERPWork_order_item>
    {
        public Work_order_itemService(ERPNextClient client)
            : base(DocType.Work_order_item, client) { }

        protected override ERPWork_order_item fromERPObject(ERPObject obj)
        {
            return new ERPWork_order_item(obj);
        }
    }
}