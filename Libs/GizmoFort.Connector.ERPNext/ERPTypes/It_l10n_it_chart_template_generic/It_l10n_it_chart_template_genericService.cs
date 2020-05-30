using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.It_l10n_it_chart_template_generic
{
    public class It_l10n_it_chart_template_genericService : SubServiceBase<ERPIt_l10n_it_chart_template_generic>
    {
        public It_l10n_it_chart_template_genericService(ERPNextClient client)
            : base(DocType.It_l10n_it_chart_template_generic, client) { }

        protected override ERPIt_l10n_it_chart_template_generic fromERPObject(ERPObject obj)
        {
            return new ERPIt_l10n_it_chart_template_generic(obj);
        }
    }
}