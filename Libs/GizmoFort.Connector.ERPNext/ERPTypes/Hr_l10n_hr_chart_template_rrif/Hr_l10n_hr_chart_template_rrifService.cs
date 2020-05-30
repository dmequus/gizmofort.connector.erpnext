using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Hr_l10n_hr_chart_template_rrif
{
    public class Hr_l10n_hr_chart_template_rrifService : SubServiceBase<ERPHr_l10n_hr_chart_template_rrif>
    {
        public Hr_l10n_hr_chart_template_rrifService(ERPNextClient client)
            : base(DocType.Hr_l10n_hr_chart_template_rrif, client) { }

        protected override ERPHr_l10n_hr_chart_template_rrif fromERPObject(ERPObject obj)
        {
            return new ERPHr_l10n_hr_chart_template_rrif(obj);
        }
    }
}