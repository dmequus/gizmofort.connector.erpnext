using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hn_cuentas_plantilla
{
    public class Hn_cuentas_plantillaService : SubServiceBase<ERPHn_cuentas_plantilla>
    {
        public Hn_cuentas_plantillaService(ERPNextClient client)
            : base(DocType.Hn_cuentas_plantilla, client) { }

        protected override ERPHn_cuentas_plantilla fromERPObject(ERPObject obj)
        {
            return new ERPHn_cuentas_plantilla(obj);
        }
    }
}