using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pa_l10npa_chart_template
{
    public class Pa_l10npa_chart_templateService : SubServiceBase<ERPPa_l10npa_chart_template>
    {
        public Pa_l10npa_chart_templateService(ERPNextClient client)
            : base(DocType.Pa_l10npa_chart_template, client) { }

        protected override ERPPa_l10npa_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPPa_l10npa_chart_template(obj);
        }
    }
}