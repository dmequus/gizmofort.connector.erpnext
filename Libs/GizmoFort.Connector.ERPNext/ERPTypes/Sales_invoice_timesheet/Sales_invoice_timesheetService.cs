using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice_timesheet
{
    public class Sales_invoice_timesheetService : SubServiceBase<ERPSales_invoice_timesheet>
    {
        public Sales_invoice_timesheetService(ERPNextClient client)
            : base(DocType.Sales_invoice_timesheet, client) { }

        protected override ERPSales_invoice_timesheet fromERPObject(ERPObject obj)
        {
            return new ERPSales_invoice_timesheet(obj);
        }
    }
}