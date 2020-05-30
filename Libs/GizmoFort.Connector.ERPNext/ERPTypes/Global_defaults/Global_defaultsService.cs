using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Global_defaults
{
    public class Global_defaultsService : SubServiceBase<ERPGlobal_defaults>
    {
        public Global_defaultsService(ERPNextClient client)
            : base(DocType.Global_defaults, client) { }

        protected override ERPGlobal_defaults fromERPObject(ERPObject obj)
        {
            return new ERPGlobal_defaults(obj);
        }
    }
}