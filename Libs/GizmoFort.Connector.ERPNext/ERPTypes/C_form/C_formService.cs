using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.C_form
{
    public class C_formService : SubServiceBase<ERPC_form>
    {
        public C_formService(ERPNextClient client)
            : base(DocType.C_form, client) { }

        protected override ERPC_form fromERPObject(ERPObject obj)
        {
            return new ERPC_form(obj);
        }
    }
}