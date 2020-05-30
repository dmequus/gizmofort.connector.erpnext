using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sg_default_coa
{
    public class Sg_default_coaService : SubServiceBase<ERPSg_default_coa>
    {
        public Sg_default_coaService(ERPNextClient client)
            : base(DocType.Sg_default_coa, client) { }

        protected override ERPSg_default_coa fromERPObject(ERPObject obj)
        {
            return new ERPSg_default_coa(obj);
        }
    }
}