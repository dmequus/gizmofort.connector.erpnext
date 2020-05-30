using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Daily_work_summary
{
    public class Daily_work_summaryService : SubServiceBase<ERPDaily_work_summary>
    {
        public Daily_work_summaryService(ERPNextClient client)
            : base(DocType.Daily_work_summary, client) { }

        protected override ERPDaily_work_summary fromERPObject(ERPObject obj)
        {
            return new ERPDaily_work_summary(obj);
        }
    }
}