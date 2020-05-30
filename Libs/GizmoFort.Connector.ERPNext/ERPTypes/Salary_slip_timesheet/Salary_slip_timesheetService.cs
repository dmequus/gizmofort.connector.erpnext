using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_slip_timesheet
{
    public class Salary_slip_timesheetService : SubServiceBase<ERPSalary_slip_timesheet>
    {
        public Salary_slip_timesheetService(ERPNextClient client)
            : base(DocType.Salary_slip_timesheet, client) { }

        protected override ERPSalary_slip_timesheet fromERPObject(ERPObject obj)
        {
            return new ERPSalary_slip_timesheet(obj);
        }
    }
}