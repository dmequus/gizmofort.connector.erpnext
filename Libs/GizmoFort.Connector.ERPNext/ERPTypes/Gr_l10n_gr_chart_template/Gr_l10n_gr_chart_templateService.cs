using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Gr_l10n_gr_chart_template
{
    public class Gr_l10n_gr_chart_templateService : SubServiceBase<ERPGr_l10n_gr_chart_template>
    {
        public Gr_l10n_gr_chart_templateService(ERPNextClient client)
            : base(DocType.Gr_l10n_gr_chart_template, client) { }

        protected override ERPGr_l10n_gr_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPGr_l10n_gr_chart_template(obj);
        }
    }
}