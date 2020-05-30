using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Gocardless_mandate
{
    public class Gocardless_mandateService : SubServiceBase<ERPGocardless_mandate>
    {
        public Gocardless_mandateService(ERPNextClient client)
            : base(DocType.Gocardless_mandate, client) { }

        protected override ERPGocardless_mandate fromERPObject(ERPObject obj)
        {
            return new ERPGocardless_mandate(obj);
        }
    }
}