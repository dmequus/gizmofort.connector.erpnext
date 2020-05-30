using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Volunteer
{
    public class VolunteerService : SubServiceBase<ERPVolunteer>
    {
        public VolunteerService(ERPNextClient client)
            : base(DocType.Volunteer, client) { }

        protected override ERPVolunteer fromERPObject(ERPObject obj)
        {
            return new ERPVolunteer(obj);
        }
    }
}