using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Membership_type
{
    public class Membership_typeService : SubServiceBase<ERPMembership_type>
    {
        public Membership_typeService(ERPNextClient client)
            : base(DocType.Membership_type, client) { }

        protected override ERPMembership_type fromERPObject(ERPObject obj)
        {
            return new ERPMembership_type(obj);
        }
    }
}