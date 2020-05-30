using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Es_account_chart_template_common
{
    public class Es_account_chart_template_commonService : SubServiceBase<ERPEs_account_chart_template_common>
    {
        public Es_account_chart_template_commonService(ERPNextClient client)
            : base(DocType.Es_account_chart_template_common, client) { }

        protected override ERPEs_account_chart_template_common fromERPObject(ERPObject obj)
        {
            return new ERPEs_account_chart_template_common(obj);
        }
    }
}