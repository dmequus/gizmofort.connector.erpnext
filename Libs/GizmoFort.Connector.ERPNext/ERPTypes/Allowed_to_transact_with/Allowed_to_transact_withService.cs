using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Allowed_to_transact_with
{
    public class Allowed_to_transact_withService : SubServiceBase<ERPAllowed_to_transact_with>
    {
        public Allowed_to_transact_withService(ERPNextClient client)
            : base(DocType.Allowed_to_transact_with, client) { }

        protected override ERPAllowed_to_transact_with fromERPObject(ERPObject obj)
        {
            return new ERPAllowed_to_transact_with(obj);
        }
    }
}