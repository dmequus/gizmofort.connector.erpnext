using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_goal
{
    public class Quality_goalService : SubServiceBase<ERPQuality_goal>
    {
        public Quality_goalService(ERPNextClient client)
            : base(DocType.Quality_goal, client) { }

        protected override ERPQuality_goal fromERPObject(ERPObject obj)
        {
            return new ERPQuality_goal(obj);
        }
    }
}