using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Warranty_claim
{
    public class Warranty_claimService : SubServiceBase<ERPWarranty_claim>
    {
        public Warranty_claimService(ERPNextClient client)
            : base(DocType.Warranty_claim, client) { }

        protected override ERPWarranty_claim fromERPObject(ERPObject obj)
        {
            return new ERPWarranty_claim(obj);
        }
    }
}