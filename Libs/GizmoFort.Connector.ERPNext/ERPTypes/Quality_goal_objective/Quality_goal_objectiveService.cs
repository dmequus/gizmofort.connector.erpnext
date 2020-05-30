using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_goal_objective
{
    public class Quality_goal_objectiveService : SubServiceBase<ERPQuality_goal_objective>
    {
        public Quality_goal_objectiveService(ERPNextClient client)
            : base(DocType.Quality_goal_objective, client) { }

        protected override ERPQuality_goal_objective fromERPObject(ERPObject obj)
        {
            return new ERPQuality_goal_objective(obj);
        }
    }
}