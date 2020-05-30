using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Gstr_3b_report
{
    public class Gstr_3b_reportService : SubServiceBase<ERPGstr_3b_report>
    {
        public Gstr_3b_reportService(ERPNextClient client)
            : base(DocType.Gstr_3b_report, client) { }

        protected override ERPGstr_3b_report fromERPObject(ERPObject obj)
        {
            return new ERPGstr_3b_report(obj);
        }
    }
}