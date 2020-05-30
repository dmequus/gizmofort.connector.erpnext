using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Volunteer_skill
{
    public class Volunteer_skillService : SubServiceBase<ERPVolunteer_skill>
    {
        public Volunteer_skillService(ERPNextClient client)
            : base(DocType.Volunteer_skill, client) { }

        protected override ERPVolunteer_skill fromERPObject(ERPObject obj)
        {
            return new ERPVolunteer_skill(obj);
        }
    }
}