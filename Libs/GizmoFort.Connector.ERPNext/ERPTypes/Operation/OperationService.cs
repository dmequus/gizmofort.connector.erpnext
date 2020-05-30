using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Operation
{
    public class OperationService : SubServiceBase<ERPOperation>
    {
        public OperationService(ERPNextClient client)
            : base(DocType.Operation, client) { }

        protected override ERPOperation fromERPObject(ERPObject obj)
        {
            return new ERPOperation(obj);
        }
    }
}