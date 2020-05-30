using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Work_order
{
    public class Work_orderService : SubServiceBase<ERPWork_order>
    {
        public Work_orderService(ERPNextClient client)
            : base(DocType.Work_order, client) { }

        protected override ERPWork_order fromERPObject(ERPObject obj)
        {
            return new ERPWork_order(obj);
        }
    }
}