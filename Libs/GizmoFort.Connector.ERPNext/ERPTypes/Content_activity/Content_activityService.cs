using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Content_activity
{
    public class Content_activityService : SubServiceBase<ERPContent_activity>
    {
        public Content_activityService(ERPNextClient client)
            : base(DocType.Content_activity, client) { }

        protected override ERPContent_activity fromERPObject(ERPObject obj)
        {
            return new ERPContent_activity(obj);
        }
    }
}