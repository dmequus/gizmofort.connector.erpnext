using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Work_order_operation
{
    public class Work_order_operationService : SubServiceBase<ERPWork_order_operation>
    {
        public Work_order_operationService(ERPNextClient client)
            : base(DocType.Work_order_operation, client) { }

        protected override ERPWork_order_operation fromERPObject(ERPObject obj)
        {
            return new ERPWork_order_operation(obj);
        }
    }
}