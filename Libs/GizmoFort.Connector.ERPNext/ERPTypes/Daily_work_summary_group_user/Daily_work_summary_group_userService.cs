using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Daily_work_summary_group_user
{
    public class Daily_work_summary_group_userService : SubServiceBase<ERPDaily_work_summary_group_user>
    {
        public Daily_work_summary_group_userService(ERPNextClient client)
            : base(DocType.Daily_work_summary_group_user, client) { }

        protected override ERPDaily_work_summary_group_user fromERPObject(ERPObject obj)
        {
            return new ERPDaily_work_summary_group_user(obj);
        }
    }
}