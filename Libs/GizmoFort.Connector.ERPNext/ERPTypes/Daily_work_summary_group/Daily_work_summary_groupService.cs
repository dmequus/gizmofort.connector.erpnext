using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Daily_work_summary_group
{
    public class Daily_work_summary_groupService : SubServiceBase<ERPDaily_work_summary_group>
    {
        public Daily_work_summary_groupService(ERPNextClient client)
            : base(DocType.Daily_work_summary_group, client) { }

        protected override ERPDaily_work_summary_group fromERPObject(ERPObject obj)
        {
            return new ERPDaily_work_summary_group(obj);
        }
    }
}