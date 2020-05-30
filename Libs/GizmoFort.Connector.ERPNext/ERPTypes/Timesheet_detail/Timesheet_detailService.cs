using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Timesheet_detail
{
    public class Timesheet_detailService : SubServiceBase<ERPTimesheet_detail>
    {
        public Timesheet_detailService(ERPNextClient client)
            : base(DocType.Timesheet_detail, client) { }

        protected override ERPTimesheet_detail fromERPObject(ERPObject obj)
        {
            return new ERPTimesheet_detail(obj);
        }
    }
}