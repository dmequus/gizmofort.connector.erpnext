using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.De_l10n_de_chart_template
{
    public class De_l10n_de_chart_templateService : SubServiceBase<ERPDe_l10n_de_chart_template>
    {
        public De_l10n_de_chart_templateService(ERPNextClient client)
            : base(DocType.De_l10n_de_chart_template, client) { }

        protected override ERPDe_l10n_de_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPDe_l10n_de_chart_template(obj);
        }
    }
}