using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ch_l10nch_chart_template
{
    public class Ch_l10nch_chart_templateService : SubServiceBase<ERPCh_l10nch_chart_template>
    {
        public Ch_l10nch_chart_templateService(ERPNextClient client)
            : base(DocType.Ch_l10nch_chart_template, client) { }

        protected override ERPCh_l10nch_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPCh_l10nch_chart_template(obj);
        }
    }
}