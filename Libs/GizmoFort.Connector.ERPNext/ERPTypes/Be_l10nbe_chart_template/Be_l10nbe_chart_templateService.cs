using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Be_l10nbe_chart_template
{
    public class Be_l10nbe_chart_templateService : SubServiceBase<ERPBe_l10nbe_chart_template>
    {
        public Be_l10nbe_chart_templateService(ERPNextClient client)
            : base(DocType.Be_l10nbe_chart_template, client) { }

        protected override ERPBe_l10nbe_chart_template fromERPObject(ERPObject obj)
        {
            return new ERPBe_l10nbe_chart_template(obj);
        }
    }
}