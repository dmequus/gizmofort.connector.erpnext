using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_action_resolution
{
    public class Quality_action_resolutionService : SubServiceBase<ERPQuality_action_resolution>
    {
        public Quality_action_resolutionService(ERPNextClient client)
            : base(DocType.Quality_action_resolution, client) { }

        protected override ERPQuality_action_resolution fromERPObject(ERPObject obj)
        {
            return new ERPQuality_action_resolution(obj);
        }
    }
}