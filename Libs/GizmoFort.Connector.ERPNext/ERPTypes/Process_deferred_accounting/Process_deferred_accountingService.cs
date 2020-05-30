using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Process_deferred_accounting
{
    public class Process_deferred_accountingService : SubServiceBase<ERPProcess_deferred_accounting>
    {
        public Process_deferred_accountingService(ERPNextClient client)
            : base(DocType.Process_deferred_accounting, client) { }

        protected override ERPProcess_deferred_accounting fromERPObject(ERPObject obj)
        {
            return new ERPProcess_deferred_accounting(obj);
        }
    }
}