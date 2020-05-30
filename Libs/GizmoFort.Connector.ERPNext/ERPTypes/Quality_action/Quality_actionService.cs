using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_action
{
    public class Quality_actionService : SubServiceBase<ERPQuality_action>
    {
        public Quality_actionService(ERPNextClient client)
            : base(DocType.Quality_action, client) { }

        protected override ERPQuality_action fromERPObject(ERPObject obj)
        {
            return new ERPQuality_action(obj);
        }
    }
}