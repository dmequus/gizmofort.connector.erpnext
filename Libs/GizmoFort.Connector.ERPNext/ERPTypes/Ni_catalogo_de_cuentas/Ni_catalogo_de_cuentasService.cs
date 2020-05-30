using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ni_catalogo_de_cuentas
{
    public class Ni_catalogo_de_cuentasService : SubServiceBase<ERPNi_catalogo_de_cuentas>
    {
        public Ni_catalogo_de_cuentasService(ERPNextClient client)
            : base(DocType.Ni_catalogo_de_cuentas, client) { }

        protected override ERPNi_catalogo_de_cuentas fromERPObject(ERPObject obj)
        {
            return new ERPNi_catalogo_de_cuentas(obj);
        }
    }
}