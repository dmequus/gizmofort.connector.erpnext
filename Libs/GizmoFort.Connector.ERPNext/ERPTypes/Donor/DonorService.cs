using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Donor
{
    public class DonorService : SubServiceBase<ERPDonor>
    {
        public DonorService(ERPNextClient client)
            : base(DocType.Donor, client) { }

        protected override ERPDonor fromERPObject(ERPObject obj)
        {
            return new ERPDonor(obj);
        }
    }
}