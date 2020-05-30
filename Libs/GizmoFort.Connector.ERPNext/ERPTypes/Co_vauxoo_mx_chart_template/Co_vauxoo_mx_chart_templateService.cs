using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Co_vauxoo_mx_chart_template
{
    public class Co_vauxoo_mx_chart_templateService : SubServiceBase<ERPCo_vauxoo_mx_chart_template>
    {
        public Co_vauxoo_mx_chart_templateService(ERPNextClient client)
            : base(DocType.Co_vauxoo_mx_chart_template, client) { }

        protected override ERPCo_vauxoo_mx_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPCo_vauxoo_mx_chart_template(obj);
        }
    }
}