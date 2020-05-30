using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Gt_cuentas_plantilla
{
    public class Gt_cuentas_plantillaService : SubServiceBase<ERPGt_cuentas_plantilla>
    {
        public Gt_cuentas_plantillaService(ERPNextClient client)
            : base(DocType.Gt_cuentas_plantilla, client) { }

        protected override ERPGt_cuentas_plantilla fromERPObject(ERPObject obj)
        {
            return new ERPGt_cuentas_plantilla(obj);
        }
    }
}