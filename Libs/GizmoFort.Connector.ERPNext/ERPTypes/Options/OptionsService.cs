using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Options
{
    public class OptionsService : SubServiceBase<ERPOptions>
    {
        public OptionsService(ERPNextClient client)
            : base(DocType.Options, client) { }

        protected override ERPOptions fromERPObject(ERPObject obj)
        {
            return new ERPOptions(obj);
        }
    }
}