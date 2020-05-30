using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sg_fnb_coa
{
    public class Sg_fnb_coaService : SubServiceBase<ERPSg_fnb_coa>
    {
        public Sg_fnb_coaService(ERPNextClient client)
            : base(DocType.Sg_fnb_coa, client) { }

        protected override ERPSg_fnb_coa fromERPObject(ERPObject obj)
        {
            return new ERPSg_fnb_coa(obj);
        }
    }
}