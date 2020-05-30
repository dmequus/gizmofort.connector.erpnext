using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Timesheet
{
    public class TimesheetService : SubServiceBase<ERPTimesheet>
    {
        public TimesheetService(ERPNextClient client)
            : base(DocType.Timesheet, client) { }

        protected override ERPTimesheet fromERPObject(ERPObject obj)
        {
            return new ERPTimesheet(obj);
        }
    }
}