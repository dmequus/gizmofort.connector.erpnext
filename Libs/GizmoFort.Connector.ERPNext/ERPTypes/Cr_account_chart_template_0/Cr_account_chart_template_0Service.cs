using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Cr_account_chart_template_0
{
    public class Cr_account_chart_template_0Service : SubServiceBase<ERPCr_account_chart_template_0>
    {
        public Cr_account_chart_template_0Service(ERPNextClient client)
            : base(DocType.Cr_account_chart_template_0, client) { }

        protected override ERPCr_account_chart_template_0 fromERPObject(ERPObject obj)
        {
            return new ERPCr_account_chart_template_0(obj);
        }
    }
}