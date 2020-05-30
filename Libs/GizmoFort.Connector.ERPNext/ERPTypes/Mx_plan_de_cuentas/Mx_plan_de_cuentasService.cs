using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Mx_plan_de_cuentas
{
    public class Mx_plan_de_cuentasService : SubServiceBase<ERPMx_plan_de_cuentas>
    {
        public Mx_plan_de_cuentasService(ERPNextClient client)
            : base(DocType.Mx_plan_de_cuentas, client) { }

        protected override ERPMx_plan_de_cuentas fromERPObject(ERPObject obj)
        {
            return new ERPMx_plan_de_cuentas(obj);
        }
    }
}