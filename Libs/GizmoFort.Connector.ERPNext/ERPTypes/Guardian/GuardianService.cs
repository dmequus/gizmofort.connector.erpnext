using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Guardian
{
    public class GuardianService : SubServiceBase<ERPGuardian>
    {
        public GuardianService(ERPNextClient client)
            : base(DocType.Guardian, client) { }

        protected override ERPGuardian fromERPObject(ERPObject obj)
        {
            return new ERPGuardian(obj);
        }
    }
}