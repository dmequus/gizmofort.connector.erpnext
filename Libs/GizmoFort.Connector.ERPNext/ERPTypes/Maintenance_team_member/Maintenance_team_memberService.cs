using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_team_member
{
    public class Maintenance_team_memberService : SubServiceBase<ERPMaintenance_team_member>
    {
        public Maintenance_team_memberService(ERPNextClient client)
            : base(DocType.Maintenance_team_member, client) { }

        protected override ERPMaintenance_team_member fromERPObject(ERPObject obj)
        {
            return new ERPMaintenance_team_member(obj);
        }
    }
}