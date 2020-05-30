using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Volunteer_type
{
    public class Volunteer_typeService : SubServiceBase<ERPVolunteer_type>
    {
        public Volunteer_typeService(ERPNextClient client)
            : base(DocType.Volunteer_type, client) { }

        protected override ERPVolunteer_type fromERPObject(ERPObject obj)
        {
            return new ERPVolunteer_type(obj);
        }
    }
}