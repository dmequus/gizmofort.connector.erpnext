using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Nl_grootboekschema
{
    public class Nl_grootboekschemaService : SubServiceBase<ERPNl_grootboekschema>
    {
        public Nl_grootboekschemaService(ERPNextClient client)
            : base(DocType.Nl_grootboekschema, client) { }

        protected override ERPNl_grootboekschema fromERPObject(ERPObject obj)
        {
            return new ERPNl_grootboekschema(obj);
        }
    }
}