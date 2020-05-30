using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_customer_detail
{
    public class Item_customer_detailService : SubServiceBase<ERPItem_customer_detail>
    {
        public Item_customer_detailService(ERPNextClient client)
            : base(DocType.Item_customer_detail, client) { }

        protected override ERPItem_customer_detail fromERPObject(ERPObject obj)
        {
            return new ERPItem_customer_detail(obj);
        }
    }
}