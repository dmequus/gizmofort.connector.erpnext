using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ae_uae_chart_template_standard
{
    public class Ae_uae_chart_template_standardService : SubServiceBase<ERPAe_uae_chart_template_standard>
    {
        public Ae_uae_chart_template_standardService(ERPNextClient client)
            : base(DocType.Ae_uae_chart_template_standard, client) { }

        protected override ERPAe_uae_chart_template_standard fromERPObject(ERPObject obj)
        {
            return new ERPAe_uae_chart_template_standard(obj);
        }
    }
}