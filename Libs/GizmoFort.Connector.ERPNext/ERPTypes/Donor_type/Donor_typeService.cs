using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Donor_type
{
    public class Donor_typeService : SubServiceBase<ERPDonor_type>
    {
        public Donor_typeService(ERPNextClient client)
            : base(DocType.Donor_type, client) { }

        protected override ERPDonor_type fromERPObject(ERPObject obj)
        {
            return new ERPDonor_type(obj);
        }
    }
}