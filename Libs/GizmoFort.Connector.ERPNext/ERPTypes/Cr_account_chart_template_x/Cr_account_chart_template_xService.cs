using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Cr_account_chart_template_x
{
    public class Cr_account_chart_template_xService : SubServiceBase<ERPCr_account_chart_template_x>
    {
        public Cr_account_chart_template_xService(ERPNextClient client)
            : base(DocType.Cr_account_chart_template_x, client) { }

        protected override ERPCr_account_chart_template_x fromERPObject(ERPObject obj)
        {
            return new ERPCr_account_chart_template_x(obj);
        }
    }
}